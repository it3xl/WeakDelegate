# Weak Delegate .NET

This is a working concept of a weak delegate for .NET Framework.<br/>
It is like the .NET Weak Reference but for methods and delegates.

It is used in production systems and is very useful with solving of .NET Framework memory leaks.

Have a fun to use.

## How to use
Mostly it will be used like the any [Action](http://msdn.microsoft.com/en-us/library/018hxwa8(v=vs.110).aspx) or [Func](http://msdn.microsoft.com/en-us/library/bb549151(v=vs.110).aspx) delegates of .NET Framework.

You should kinda wrap your method reference by a **WeakAction** or **WeakFunk** class.
Voila, we have your firs weak delegate and you can do any your raw (dirty) coding.

## Key tips
On top of this project of the Weak Delegate were created projects:
* [Weak Event](http://weakevent.codeplex.com)
* [Weak Closure Pattern](http://weakclosure.codeplex.com)

## tl;dr if you want to take some deeper

It was intentionally created to support older versions of .NET.
I.e. for .NET 4.0 and Silverlight 4.

It does not require any effort to convert it to the newest .NET versions.<br/>
It is easy to adapt it to the .NET 3.0 or 3.5.<br/>
But it requires some tentions to adapt it for the **.NET 2.0** (It's a matter of time but approaches are ready).
