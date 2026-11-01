using System;

public abstract class BackupPlan
{
    public string Name { get; }

    protected BackupPlan(string name)
    {
        Name = name;
    }
}

public interface IValue
{
    int GetValue();
}

public class CopyPlan : BackupPlan, IValue
{
    public int Files { get; }
    public int SizeMb { get; }

    public CopyPlan(string name, int x, int y) : base(name)
    {
        Files = x;
        SizeMb = y;
    }

    public int GetValue()
    {
        return Files * SizeMb;
    }
}

public class Calculator
{
    public int Total(IValue[] items)
    {
        int total = 0;
        foreach (IValue item in items)
            total += item.GetValue();
        return total;
    }
}

public class ConstantValue : IValue
{
    public int GetValue()
    {
        return 7;
    }
}
