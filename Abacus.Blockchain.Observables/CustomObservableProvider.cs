﻿using System;
using System.Linq.Expressions;
using IQbservableProvider = System.Reactive.Linq.IQbservableProvider;

namespace Abacus.Observables
{
public class CustomObservableProvider : IQbservableProvider
{
    public IQbservable<TElement> CreateQuery<TElement>(Expression expression)
    {
        return new CustomObservable<TElement>(expression);
    }
}
}