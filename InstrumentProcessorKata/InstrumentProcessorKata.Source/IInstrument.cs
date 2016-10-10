using System;

namespace InstrumentProcessorKata.Source
{
    public interface IInstrument
    {
        void Execute(string task);

        event EventHandler Finished;
        event EventHandler Error;
    }
}
