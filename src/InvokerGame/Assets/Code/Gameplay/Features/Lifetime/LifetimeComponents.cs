﻿using Entitas;

namespace Code.Gameplay.Features.LifeTime
{
    [Game] public class MaxHp : IComponent { public float Value; }
    [Game] public class CurrentHp : IComponent { public float Value; }
}