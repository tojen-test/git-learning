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
        public AudioClip[] Clip;
        [Range(0f,1f)]
        public float Volume = 0.5f;
    }

    public enum AudioType
    {
        Clicks,
        GameResult,
        Room1Amb,
        Room2Amb,
        Steps1,
        StepsRun1,
        StepsWater2,
        StepsRunWater2,
        Shouts,
        Breath,
        AttackHunter,
        DoorOpen,
        Coin,
        TimerStartHunter,
        TimerStartVictim,
        Performing,
        PerformingDone,
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