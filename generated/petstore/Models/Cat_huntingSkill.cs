using System.Runtime.Serialization;
using System;
namespace PetStore.Models {
    /// <summary>The measured skill for hunting</summary>
    public enum Cat_huntingSkill {
        [EnumMember(Value = "clueless")]
        Clueless,
        [EnumMember(Value = "lazy")]
        Lazy,
        [EnumMember(Value = "adventurous")]
        Adventurous,
        [EnumMember(Value = "aggressive")]
        Aggressive,
    }
}
