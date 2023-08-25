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
        public float Volume = 0.1f;
    }

    public enum AudioType
    {
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