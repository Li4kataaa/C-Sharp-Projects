﻿namespace CollectionHierarchy
{ 
    public interface IAddRemoveCollection<T> : IAddCollection<T>
    {
        T Remove();
    }
}
