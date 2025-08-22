using System;
using System.Collections.Generic;
using System.Linq;

public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }

    public int Distance(Coord other) =>
        Math.Abs(this.X - other.X) + Math.Abs(this.Y - other.Y);
}

public struct Plot
{
    public Plot(Coord one, Coord two, Coord three, Coord four)
    {
        this.CoordOne = one;
        this.CoordTwo = two;
        this.CoordThree = three;
        this.CoordFour = four;

        this.LongestSide = Math.Max(Math.Max(one.Distance(two), two.Distance(three)), Math.Max(three.Distance(four), four.Distance(one)));
    }

    public Coord CoordOne;
    public Coord CoordTwo;
    public Coord CoordThree;
    public Coord CoordFour;

    public int LongestSide;
}


public class ClaimsHandler
{
    public void StakeClaim(Plot plot)
    {
        if (!IsClaimStaked(plot)) this.Claims.Add(plot);
    }

    public bool IsClaimStaked(Plot plot) =>
        this.Claims.Contains(plot);

    public bool IsLastClaim(Plot plot) =>
        this.Claims[Claims.Count - 1].Equals(plot);

    public Plot GetClaimWithLongestSide() =>
        this.Claims.OrderByDescending(plot => plot.LongestSide).First();

    public List<Plot> Claims = new List<Plot>();
}
