using System;
using FluentAssertions;
using InstrumentProcessorKata.Source;
using Moq;
using NUnit.Framework;

namespace InstrumentProcessorKata.Tests
{
    [TestFixture]
    public class InstrumentProcessorShould
    {
        private Mock<IInstrument> _instrument = new Mock<IInstrument>();
        private Mock<ITaskDispatcher> _taskDispatcher = new Mock<ITaskDispatcher>();
        private IInstrumentProcessor _instrumentProcessor;

        [SetUp]
        public void Setup()
        {
            _instrumentProcessor = new InstrumentProcessor(_instrument.Object, _taskDispatcher.Object);
        }

        [Test]
        public void ExecuteATask_WhenProcessing()
        {           
            var task = Guid.NewGuid().ToString();
            _taskDispatcher.Setup(td => td.GetTask()).Returns(task);

            _instrumentProcessor.Process();

            _instrument.Verify(i => i.Execute(task), Times.Once);
        }

        [Test]
        public void Complain_GivenNullTaskPassed()
        {
            var nullTask = (string)null;
            _taskDispatcher.Setup(td => td.GetTask()).Returns(nullTask);
            _instrument.Setup(i => i.Execute(nullTask)).Throws<ArgumentNullException>();

            Action processing = () => _instrumentProcessor.Process();

            processing.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void FinishTheTask_GivenNotifiedEventFinished()
        {
            var task = Guid.NewGuid().ToString();
            _taskDispatcher.Setup(td => td.GetTask()).Returns(task);
            _instrument.Setup(i => i.Execute(task)).Raises(i => i.Finished += null, new FinishedTaskArgs(task));

            _instrumentProcessor.Process();

            _taskDispatcher.Verify(td => td.FinishedTask(task), Times.Once);
        }
    }
}
