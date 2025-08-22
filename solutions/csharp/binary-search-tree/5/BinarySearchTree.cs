using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class BinarySearchTree : IEnumerable<int>
{
    public BinarySearchTree(params int[] values)
    {
        if (values.Length == 0) throw new ArgumentException("Cannot create tree from empty list");
        this.Value = values[0];
        foreach (var value in values.Skip(1))
            this.Add(value);
    }

    public int Value { get; } = 0;

    public BinarySearchTree Left { get; private set; }

    public BinarySearchTree Right { get; private set; }

    public BinarySearchTree Add(int value)
    {
        if (value <= Value)
            this.Left = Add(value, Left);
        else
            this.Right = Add(value, Right);
        return this;
    }

    private static BinarySearchTree Add(int value, BinarySearchTree tree)
    {
        if (tree == null)
            return new BinarySearchTree(value);
        return tree.Add(value);
    }

    public IEnumerator<int> GetEnumerator()
    {
        foreach (int left in Left?.AsEnumerable() ?? Enumerable.Empty<int>())
            yield return left;
        yield return Value;
        foreach (int right in Right?.AsEnumerable() ?? Enumerable.Empty<int>())
            yield return right;
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}