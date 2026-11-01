using System;
using System.Collections.Generic;
public class Operator
{
    public string Name { get; }
    public Operator(string name) { Name = name; }
}
public class Crew
{
    private readonly List<Operator> members = new();
    public void Add(Operator p)
    {
        if (!members.Contains(p)) members.Add(p);
    }
}
public class CopyRecord
{
    public Operator Person { get; }
    public int Value { get; }
    public CopyRecord(Operator p, int value)
    { Person = p; Value = value; }
}
public class BackupLog
{
    private readonly List<CopyRecord> records = new();
    public void Add(Operator p, int value)
    {
        records.Add(new CopyRecord(p, value));
    }
    public int Result()
    {
        int total = 0;
        foreach (var r in records)
            if (r.Value >= 5) total++;
        return total;
    }
}
