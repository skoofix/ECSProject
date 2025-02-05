//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherOrbId;

    public static Entitas.IMatcher<GameEntity> OrbId {
        get {
            if (_matcherOrbId == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.OrbId);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherOrbId = matcher;
            }

            return _matcherOrbId;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.Gameplay.Features.Orb.OrbId orbId { get { return (Code.Gameplay.Features.Orb.OrbId)GetComponent(GameComponentsLookup.OrbId); } }
    public Code.Gameplay.Features.Orb.OrbTypeId OrbId { get { return orbId.Value; } }
    public bool hasOrbId { get { return HasComponent(GameComponentsLookup.OrbId); } }

    public GameEntity AddOrbId(Code.Gameplay.Features.Orb.OrbTypeId newValue) {
        var index = GameComponentsLookup.OrbId;
        var component = (Code.Gameplay.Features.Orb.OrbId)CreateComponent(index, typeof(Code.Gameplay.Features.Orb.OrbId));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceOrbId(Code.Gameplay.Features.Orb.OrbTypeId newValue) {
        var index = GameComponentsLookup.OrbId;
        var component = (Code.Gameplay.Features.Orb.OrbId)CreateComponent(index, typeof(Code.Gameplay.Features.Orb.OrbId));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveOrbId() {
        RemoveComponent(GameComponentsLookup.OrbId);
        return this;
    }
}
