﻿using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._CM14.Marines.Skills;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SkillsSystem))]
public sealed partial class RequiresSkillComponent : Component
{
    [DataField(required: true), AutoNetworkedField]
    public Dictionary<EntProtoId<SkillDefinitionComponent>, int> Skills = new();
}
