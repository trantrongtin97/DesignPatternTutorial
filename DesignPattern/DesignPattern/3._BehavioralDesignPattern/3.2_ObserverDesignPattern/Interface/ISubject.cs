﻿namespace DesignPattern.BehavioralDesignPattern.ObserverDesignPattern.Interface
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
