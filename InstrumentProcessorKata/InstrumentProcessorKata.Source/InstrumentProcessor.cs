using System;
using System.Runtime.InteropServices;

namespace InstrumentProcessorKata.Source
{
    public class InstrumentProcessor : IInstrumentProcessor
    {
        private readonly IInstrument _instrument;
        private readonly ITaskDispatcher _taskDispatcher;

        public InstrumentProcessor(IInstrument instrument, ITaskDispatcher taskDispatcher)
        {
            _instrument = instrument;
            _taskDispatcher = taskDispatcher;
            _instrument.Finished += OnFinishedTask;
        }

        public void Process()
        {
            var task = _taskDispatcher.GetTask();
            _instrument.Execute(task);
        }

        public void OnFinishedTask(object sender, EventArgs args)
        {
            FinishedTaskArgs taskArgs = args as FinishedTaskArgs;
            _taskDispatcher.FinishedTask(taskArgs.Task);
        }
    }
}