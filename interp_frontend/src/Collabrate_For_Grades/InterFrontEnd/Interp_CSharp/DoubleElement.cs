﻿////////////////////////////////////////////////////////////////////////
// IntegerElement.cs: holds the data needed to represent an Integer.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class DoubleElement : Element
{

    String mText;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitDoubleElement(this);
    }

    public String getText() { return mText; }
    public void setText(String value) { mText = value; }
}
