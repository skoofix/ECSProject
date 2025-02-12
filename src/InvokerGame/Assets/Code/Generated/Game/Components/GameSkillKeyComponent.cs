//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSkillKey;

    public static Entitas.IMatcher<GameEntity> SkillKey {
        get {
            if (_matcherSkillKey == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SkillKey);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSkillKey = matcher;
            }

            return _matcherSkillKey;
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

    public Code.Gameplay.Input.SkillKey skillKey { get { return (Code.Gameplay.Input.SkillKey)GetComponent(GameComponentsLookup.SkillKey); } }
    public UnityEngine.KeyCode SkillKey { get { return skillKey.Value; } }
    public bool hasSkillKey { get { return HasComponent(GameComponentsLookup.SkillKey); } }

    public GameEntity AddSkillKey(UnityEngine.KeyCode newValue) {
        var index = GameComponentsLookup.SkillKey;
        var component = (Code.Gameplay.Input.SkillKey)CreateComponent(index, typeof(Code.Gameplay.Input.SkillKey));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceSkillKey(UnityEngine.KeyCode newValue) {
        var index = GameComponentsLookup.SkillKey;
        var component = (Code.Gameplay.Input.SkillKey)CreateComponent(index, typeof(Code.Gameplay.Input.SkillKey));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveSkillKey() {
        RemoveComponent(GameComponentsLookup.SkillKey);
        return this;
    }
}
