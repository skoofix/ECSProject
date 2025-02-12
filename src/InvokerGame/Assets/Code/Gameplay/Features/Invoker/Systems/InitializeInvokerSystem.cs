﻿using Code.Gameplay.Features.Invoker.Factory;
using Code.Gameplay.Levels;
using Entitas;

namespace Code.Gameplay.Features.Invoker.Systems
{
    public class InitializeInvokerSystem : IInitializeSystem
    {
        private readonly IInvokerFactory _invokerFactory;
        private readonly ILevelDataProvider _levelDataProvider;

        public InitializeInvokerSystem(IInvokerFactory invokerFactory, ILevelDataProvider levelDataProvider)
        {
            _invokerFactory = invokerFactory;
            _levelDataProvider = levelDataProvider;
        }
        
        public void Initialize()
        {
            _invokerFactory.CreateInvoker(_levelDataProvider.StartPoint);
        }
    }
}