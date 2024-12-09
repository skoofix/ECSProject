﻿using Code.Gameplay.Features.Movement.Systems;
using Code.Gameplay.Features.Spells.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Movement
{
    public class MovementFeature : Feature
    {
        public MovementFeature(ISystemFactory systems)
        {
            Add(systems.Create<DirectionalDeltaMoveSystem>());
            Add(systems.Create<FallingSystem>());
            Add(systems.Create<UpdateTransformPositionSystem>());
        }
    }
}