using System;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Ingame;
using IMyGridTerminalSystem = Sandbox.ModAPI.Ingame.IMyGridTerminalSystem;
using IMyProgrammableBlock = Sandbox.ModAPI.Ingame.IMyProgrammableBlock;

public class AbstractScript : IMyGridProgram
{
    public void Main(string argument)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public IMyGridTerminalSystem GridTerminalSystem { get; set; }
    public IMyProgrammableBlock Me { get; set; }
    public TimeSpan ElapsedTime { get; set; }
    public string Storage { get; set; }
    public IMyGridProgramRuntimeInfo Runtime { get; set; }
    public Action<string> Echo { get; set; }
    public bool HasMainMethod { get; private set; }
    public bool HasSaveMethod { get; private set; }
}