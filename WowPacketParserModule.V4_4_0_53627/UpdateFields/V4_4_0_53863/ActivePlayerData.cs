using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V4_4_0_53627.UpdateFields.V4_4_0_53863
{
    public class ActivePlayerData : IActivePlayerData
    {
        public WowGuid[] InvSlots { get; } = new WowGuid[141];
        public WowGuid FarsightObject { get; set; }
        public WowGuid SummonedBattlePetGUID { get; set; }
        public System.Nullable<ulong> Coinage { get; set; }
        public System.Nullable<int> XP { get; set; }
        public System.Nullable<int> NextLevelXP { get; set; }
        public System.Nullable<int> TrialXP { get; set; }
        public ISkillInfo Skill { get; set; }
        public System.Nullable<int> CharacterPoints { get; set; }
        public System.Nullable<int> MaxTalentTiers { get; set; }
        public System.Nullable<uint> TrackCreatureMask { get; set; }
        public System.Nullable<uint>[] TrackResourceMask { get; } = new System.Nullable<uint>[2];
        public System.Nullable<float> MainhandExpertise { get; set; }
        public System.Nullable<float> OffhandExpertise { get; set; }
        public System.Nullable<float> RangedExpertise { get; set; }
        public System.Nullable<float> CombatRatingExpertise { get; set; }
        public System.Nullable<float> BlockPercentage { get; set; }
        public System.Nullable<float> DodgePercentage { get; set; }
        public System.Nullable<float> DodgePercentageFromAttribute { get; set; }
        public System.Nullable<float> ParryPercentage { get; set; }
        public System.Nullable<float> ParryPercentageFromAttribute { get; set; }
        public System.Nullable<float> CritPercentage { get; set; }
        public System.Nullable<float> RangedCritPercentage { get; set; }
        public System.Nullable<float> OffhandCritPercentage { get; set; }
        public System.Nullable<float>[] SpellCritPercentage { get; } = new System.Nullable<float>[7];
        public System.Nullable<int>[] ModDamageDonePos { get; } = new System.Nullable<int>[7];
        public System.Nullable<int>[] ModDamageDoneNeg { get; } = new System.Nullable<int>[7];
        public System.Nullable<float>[] ModDamageDonePercent { get; } = new System.Nullable<float>[7];
        public System.Nullable<int> ShieldBlock { get; set; }
        public System.Nullable<float> ShieldBlockCritPercentage { get; set; }
        public System.Nullable<float> Mastery { get; set; }
        public System.Nullable<float> Speed { get; set; }
        public System.Nullable<float> Avoidance { get; set; }
        public System.Nullable<float> Sturdiness { get; set; }
        public System.Nullable<int> Versatility { get; set; }
        public System.Nullable<float> VersatilityBonus { get; set; }
        public System.Nullable<float> PvpPowerDamage { get; set; }
        public System.Nullable<float> PvpPowerHealing { get; set; }
        public IRestInfo[] RestInfo { get; } = new IRestInfo[2];
        public System.Nullable<int> ModHealingDonePos { get; set; }
        public System.Nullable<float> ModHealingPercent { get; set; }
        public System.Nullable<float> ModHealingDonePercent { get; set; }
        public System.Nullable<float> ModPeriodicHealingDonePercent { get; set; }
        public System.Nullable<float>[] WeaponDmgMultipliers { get; } = new System.Nullable<float>[3];
        public System.Nullable<float>[] WeaponAtkSpeedMultipliers { get; } = new System.Nullable<float>[3];
        public System.Nullable<float> ModSpellPowerPercent { get; set; }
        public System.Nullable<float> ModResiliencePercent { get; set; }
        public System.Nullable<float> OverrideSpellPowerByAPPercent { get; set; }
        public System.Nullable<float> OverrideAPBySpellPowerPercent { get; set; }
        public System.Nullable<int> ModTargetResistance { get; set; }
        public System.Nullable<int> ModTargetPhysicalResistance { get; set; }
        public System.Nullable<uint> LocalFlags { get; set; }
        public System.Nullable<byte> GrantableLevels { get; set; }
        public System.Nullable<byte> MultiActionBars { get; set; }
        public System.Nullable<byte> LifetimeMaxRank { get; set; }
        public System.Nullable<byte> NumRespecs { get; set; }
        public System.Nullable<int> AmmoID { get; set; }
        public System.Nullable<uint> PvpMedals { get; set; }
        public System.Nullable<uint>[] BuybackPrice { get; } = new System.Nullable<uint>[12];
        public System.Nullable<long>[] BuybackTimestamp { get; } = new System.Nullable<long>[12];
        public System.Nullable<ushort> TodayHonorableKills { get; set; }
        public System.Nullable<ushort> TodayDishonorableKills { get; set; }
        public System.Nullable<ushort> YesterdayHonorableKills { get; set; }
        public System.Nullable<ushort> YesterdayDishonorableKills { get; set; }
        public System.Nullable<ushort> LastWeekHonorableKills { get; set; }
        public System.Nullable<ushort> LastWeekDishonorableKills { get; set; }
        public System.Nullable<ushort> ThisWeekHonorableKills { get; set; }
        public System.Nullable<ushort> ThisWeekDishonorableKills { get; set; }
        public System.Nullable<uint> ThisWeekContribution { get; set; }
        public System.Nullable<uint> LifetimeHonorableKills { get; set; }
        public System.Nullable<uint> LifetimeDishonorableKills { get; set; }
        public System.Nullable<uint> Field_F24 { get; set; }
        public System.Nullable<uint> YesterdayContribution { get; set; }
        public System.Nullable<uint> LastWeekContribution { get; set; }
        public System.Nullable<uint> LastWeekRank { get; set; }
        public System.Nullable<int> WatchedFactionIndex { get; set; }
        public System.Nullable<int>[] CombatRatings { get; } = new System.Nullable<int>[32];
        public System.Nullable<int> MaxLevel { get; set; }
        public System.Nullable<int> ScalingPlayerLevelDelta { get; set; }
        public System.Nullable<int> MaxCreatureScalingLevel { get; set; }
        public System.Nullable<uint>[] NoReagentCostMask { get; } = new System.Nullable<uint>[4];
        public System.Nullable<int> PetSpellPower { get; set; }
        public System.Nullable<int>[] ProfessionSkillLine { get; } = new System.Nullable<int>[2];
        public System.Nullable<float> UiHitModifier { get; set; }
        public System.Nullable<float> UiSpellHitModifier { get; set; }
        public System.Nullable<int> HomeRealmTimeOffset { get; set; }
        public System.Nullable<float> ModPetHaste { get; set; }
        public System.Nullable<byte> LocalRegenFlags { get; set; }
        public System.Nullable<byte> AuraVision { get; set; }
        public System.Nullable<byte> NumBackpackSlots { get; set; }
        public System.Nullable<int> OverrideSpellsID { get; set; }
        public System.Nullable<int> LfgBonusFactionID { get; set; }
        public System.Nullable<ushort> LootSpecID { get; set; }
        public System.Nullable<uint> OverrideZonePVPType { get; set; }
        public System.Nullable<uint>[] BagSlotFlags { get; } = new System.Nullable<uint>[4];
        public System.Nullable<uint>[] BankBagSlotFlags { get; } = new System.Nullable<uint>[7];
        public System.Nullable<ulong>[] QuestCompleted { get; } = new System.Nullable<ulong>[950];
        public System.Nullable<int> Honor { get; set; }
        public System.Nullable<int> HonorNextLevel { get; set; }
        public System.Nullable<int> Field_F74 { get; set; }
        public System.Nullable<int> PvpTierMaxFromWins { get; set; }
        public System.Nullable<int> PvpLastWeeksTierMaxFromWins { get; set; }
        public System.Nullable<byte> PvpRankProgress { get; set; }
        public System.Nullable<int> PerksProgramCurrency { get; set; }
        public IResearchHistory ResearchHistory { get; set; }
        public System.Nullable<int> TransportServerTime { get; set; }
        public System.Nullable<uint> ActiveCombatTraitConfigID { get; set; }
        public System.Nullable<uint>[] GlyphSlots { get; } = new System.Nullable<uint>[9];
        public System.Nullable<uint>[] Glyphs { get; } = new System.Nullable<uint>[9];
        public System.Nullable<ushort> GlyphsEnabled { get; set; }
        public System.Nullable<byte> LfgRoles { get; set; }
        public IStableInfo PetStable { get; set; }
        public System.Nullable<byte> NumStableSlots { get; set; }
        public DynamicUpdateField<System.Nullable<ulong>>[] DataFlags { get; } = new DynamicUpdateField<System.Nullable<ulong>>[8] { new DynamicUpdateField<System.Nullable<ulong>>(), new DynamicUpdateField<System.Nullable<ulong>>(), new DynamicUpdateField<System.Nullable<ulong>>(), new DynamicUpdateField<System.Nullable<ulong>>(), new DynamicUpdateField<System.Nullable<ulong>>(), new DynamicUpdateField<System.Nullable<ulong>>(), new DynamicUpdateField<System.Nullable<ulong>>(), new DynamicUpdateField<System.Nullable<ulong>>() };
        public DynamicUpdateField<System.Nullable<ushort>>[] ResearchSites { get; } = new DynamicUpdateField<System.Nullable<ushort>>[1] { new DynamicUpdateField<System.Nullable<ushort>>() };
        public DynamicUpdateField<System.Nullable<uint>>[] ResearchSiteProgress { get; } = new DynamicUpdateField<System.Nullable<uint>>[1] { new DynamicUpdateField<System.Nullable<uint>>() };
        public DynamicUpdateField<IResearch>[] Research { get; } = new DynamicUpdateField<IResearch>[1] { new DynamicUpdateField<IResearch>() };
        public DynamicUpdateField<System.Nullable<ulong>> KnownTitles { get; } = new DynamicUpdateField<System.Nullable<ulong>>();
        public DynamicUpdateField<System.Nullable<int>> DailyQuestsCompleted { get; } = new DynamicUpdateField<System.Nullable<int>>();
        public DynamicUpdateField<System.Nullable<int>> AvailableQuestLineXQuestIDs { get; } = new DynamicUpdateField<System.Nullable<int>>();
        public DynamicUpdateField<System.Nullable<int>> Field_1000 { get; } = new DynamicUpdateField<System.Nullable<int>>();
        public DynamicUpdateField<System.Nullable<int>> Heirlooms { get; } = new DynamicUpdateField<System.Nullable<int>>();
        public DynamicUpdateField<System.Nullable<uint>> HeirloomFlags { get; } = new DynamicUpdateField<System.Nullable<uint>>();
        public DynamicUpdateField<System.Nullable<int>> Toys { get; } = new DynamicUpdateField<System.Nullable<int>>();
        public DynamicUpdateField<System.Nullable<uint>> Transmog { get; } = new DynamicUpdateField<System.Nullable<uint>>();
        public DynamicUpdateField<System.Nullable<int>> ConditionalTransmog { get; } = new DynamicUpdateField<System.Nullable<int>>();
        public DynamicUpdateField<System.Nullable<int>> SelfResSpells { get; } = new DynamicUpdateField<System.Nullable<int>>();
        public DynamicUpdateField<ISpellPctModByLabel> SpellPctModByLabel { get; } = new DynamicUpdateField<ISpellPctModByLabel>();
        public DynamicUpdateField<ISpellFlatModByLabel> SpellFlatModByLabel { get; } = new DynamicUpdateField<ISpellFlatModByLabel>();
        public DynamicUpdateField<IQuestLog> TaskQuests { get; } = new DynamicUpdateField<IQuestLog>();
        public DynamicUpdateField<ICategoryCooldownMod> CategoryCooldownMods { get; } = new DynamicUpdateField<ICategoryCooldownMod>();
        public DynamicUpdateField<IWeeklySpellUse> WeeklySpellUses { get; } = new DynamicUpdateField<IWeeklySpellUse>();
        public IPVPInfo[] PvpInfo { get; } = new IPVPInfo[9];
        public System.Nullable<bool> SortBagsRightToLeft { get; set; }
        public System.Nullable<bool> InsertItemsLeftToRight { get; set; }
        public DynamicUpdateField<ICharacterRestriction> CharacterRestrictions { get; } = new DynamicUpdateField<ICharacterRestriction>();
        public DynamicUpdateField<ITraitConfig> TraitConfigs { get; } = new DynamicUpdateField<ITraitConfig>();
    }
}

