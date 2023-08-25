using System;
using UnityEngine;

namespace Audio
{
    [CreateAssetMenu(fileName = "AudioSettings", menuName = "Settings/AudioSettings", order = 0)]
    public class AudioSettings : ScriptableObject
    {
        public AudioSourceUnit[] Units;
    }

    [Serializable]
    public class AudioSourceUnit
    {
        public AudioType Type;
        public AudioClip Clip;
        public float Volume = 0.1f;
    }

    public enum AudioType
    {
        Key,
        ElectroLoop,
        ElectroOff,
        Crystal,
        BirdsFlap,
        PowerDown,
        Cleaning,
        Meat,
        BrokenCamera,
        Keyboard,
        Radio,
        ArmShelves,
        ArmShelvesOff,
        Tentacle,
        Valve,
        ValveOff,
        CleanPipe,
        Ducky,
        FindStash,
        Button1,
        Button2,
        PopTheLifePreservers,
        PopBang,
        MetalBoxMonster,
        CloseMetalBox,
        FixTheWaterSlides,
        PortalClose,
        BoosterActivate,
        BoosterEnd,
        FrozenSpells,
        FrozenEnemys,
        FrozenSpellOuts,
        FrozenPunch,
        Teleport,
        HitVictim,
        DamageVictim,
        Lose,
        CountTasks,
        CountKills,
        CountCoinsLoop,
        CoinsGet,
        TimerEnding,
        TimeUp,
        Win,
        BacteriaLoop,
        SkinStealerLoop,
        PartygoerLoop,
        SlandermanLoop,
        DullerLoop,
        GameMasterLoop,
        BreathAll,
        SirenaLoop,
        HunterSteps

    }
}