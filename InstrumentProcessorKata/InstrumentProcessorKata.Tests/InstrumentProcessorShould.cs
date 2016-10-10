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
        [Test]
        public void ExecuteATask_WhenProcessing()
        {
            var instrument = new Mock<IInstrument>();
            var taskDispatcher = new Mock<ITaskDispatcher>();
            IInstrumentProcessor instrumentProcessor = new InstrumentProcessor(instrument.Object, taskDispatcher.Object);
            var task = Guid.NewGuid().ToString();
            taskDispatcher.Setup(td => td.GetTask()).Returns(task);

            instrumentProcessor.Process();

            instrument.Verify(i => i.Execute(task), Times.Once);
        }

        [Test]
        public void Complain_GivenNullTaskPassed()
        {
            var instrument = new Mock<IInstrument>();
            var taskDispatcher = new Mock<ITaskDispatcher>();
            IInstrumentProcessor instrumentProcessor = new InstrumentProcessor(instrument.Object, taskDispatcher.Object);
            var nullTask = (string)null;
            taskDispatcher.Setup(td => td.GetTask()).Returns(nullTask);
            instrument.Setup(i => i.Execute(nullTask)).Throws<ArgumentNullException>();


            Action processing = () => instrumentProcessor.Process();

            processing.ShouldThrow<ArgumentNullException>();
        }
    }
}
