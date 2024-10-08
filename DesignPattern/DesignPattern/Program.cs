﻿using DesignPattern.BehavioralDesignPattern;
using DesignPattern.CreationalDesignPattern;
using DesignPattern.Main;
using DesignPattern.StructuralDesignPattern;

CreationalDesignPattern creationalDesignPattern = new CreationalDesignPattern();
creationalDesignPattern.Basic();

StructuralDesignPattern structuralDesignPattern = new StructuralDesignPattern();
await structuralDesignPattern.BasicAsync();

BehavioralDesignPattern behavioralDesignPattern = new BehavioralDesignPattern();
behavioralDesignPattern.Basic();

DependencyInjectionDesignPattern dependencyInjectionDesignPattern = new DependencyInjectionDesignPattern();
dependencyInjectionDesignPattern.Demo();
