﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace R6Sharp
{
    public enum StatisticsType
    {
        All,
        Core,
        Firefight,
        Operator,
        General,
        Queue,
        Objective
    }

    internal static class Constant
    {
        // Includes casual, ranked, general, operator and gamemodes
        internal const string AllStatisticsVariables = "operatorpvp_smoke_poisongaskill,operatorpvp_timeplayed,operatorpvp_roundwon,operatorpvp_roundlost,operatorpvp_kills,operatorpvp_death,operatorpvp_mute_gadgetjammed,operatorpvp_thatcher_gadgetdestroywithemp,operatorpvp_castle_kevlarbarricadedeployed,operatorpvp_ash_bonfirewallbreached,operatorpvp_pulse_heartbeatspot,operatorpvp_doc_teammaterevive,operatorpvp_rook_armortakenteammate,operatorpvp_twitch_gadgetdestroybyshockdrone,operatorpvp_montagne_shieldblockdamage,operatorpvp_glaz_sniperkill,operatorpvp_fuze_clusterchargekill,operatorpvp_kapkan_boobytrapkill,operatorpvp_tachanka_turretkill,operatorpvp_iq_gadgetspotbyef,operatorpvp_jager_gadgetdestroybycatcher,operatorpvp_bandit_batterykill,operatorpvp_buck_kill,operatorpvp_frost_dbno,operatorpvp_blackbeard_gunshieldblockdamage,operatorpvp_valkyrie_camdeployed,operatorpvp_capitao_lethaldartkills,operatorpvp_echo_enemy_sonicburst_affected,operatorpvp_cazador_assist_kill,operatorpvp_black_mirror_gadget_deployed,operatorpvp_dazzler_gadget_detonate,operatorpvp_caltrop_enemy_affected,operatorpvp_concussionmine_detonate,operatorpvp_concussiongrenade_detonate,operatorpvp_phoneshacked,operatorpvp_attackerdrone_diminishedrealitymode,operatorpvp_tagger_tagdevice_spot,operatorpvp_rush_adrenalinerush,operatorpvp_barrage_killswithturret,operatorpvp_deceiver_revealedattackers,operatorpvp_maverick_wallbreached,operatorpvp_clash_sloweddown,operatorpvp_nomad_airjabdetonate,operatorpvp_kaid_electroclawelectrify,operatorpvp_gridlock_traxdeployed,operatorpvp_nokk_observationtooldeceived,operatorpvp_warden_killswithglasses,operatorpvp_goyo_volcandetonate,operatorpvp_amaru_distancereeled,operatorpvp_kali_gadgetdestroywithexplosivelance,operatorpvp_wamai_gadgetdestroybymagnet,weapontypepvp_kills,weapontypepvp_headshot,weapontypepvp_bulletfired,weapontypepvp_bullethit,generalpvp_timeplayed,generalpvp_matchplayed,generalpvp_killassists,generalpvp_revive,generalpvp_headshot,generalpvp_penetrationkills,generalpvp_meleekills,generalpvp_matchwon,generalpvp_matchlost,generalpvp_kills,generalpvp_death,generalpvp_bullethit,generalpvp_bulletfired,casualpvp_timeplayed,casualpvp_matchwon,casualpvp_matchlost,casualpvp_matchplayed,casualpvp_kills,casualpvp_death,rankedpvp_matchwon,rankedpvp_matchlost,rankedpvp_timeplayed,rankedpvp_matchplayed,rankedpvp_kills,rankedpvp_death,secureareapvp_matchwon,secureareapvp_matchlost,secureareapvp_matchplayed,secureareapvp_bestscore,rescuehostagepvp_matchwon,rescuehostagepvp_matchlost,rescuehostagepvp_matchplayed,rescuehostagepvp_bestscore,plantbombpvp_matchwon,plantbombpvp_matchlost,plantbombpvp_matchplayed,plantbombpvp_bestscore,generalpvp_timeplayed,generalpvp_matchplayed,generalpvp_killassists,generalpvp_revive,generalpvp_headshot,generalpvp_penetrationkills,generalpvp_meleekills,generalpvp_matchwon,generalpvp_matchlost,generalpvp_kills,generalpvp_death,generalpvp_bullethit,generalpvp_bulletfired,weapontypepvp_kills,weapontypepvp_headshot,weapontypepvp_bulletfired,weapontypepvp_bullethit,operatorpvp_smoke_poisongaskill,operatorpvp_timeplayed,operatorpvp_roundwon,operatorpvp_roundlost,operatorpvp_kills,operatorpvp_death,operatorpvp_mute_gadgetjammed,operatorpvp_thatcher_gadgetdestroywithemp,operatorpvp_castle_kevlarbarricadedeployed,operatorpvp_ash_bonfirewallbreached,operatorpvp_pulse_heartbeatspot,operatorpvp_doc_teammaterevive,operatorpvp_rook_armortakenteammate,operatorpvp_twitch_gadgetdestroybyshockdrone,operatorpvp_montagne_shieldblockdamage,operatorpvp_glaz_sniperkill,operatorpvp_fuze_clusterchargekill,operatorpvp_kapkan_boobytrapkill,operatorpvp_tachanka_turretkill,operatorpvp_iq_gadgetspotbyef,operatorpvp_jager_gadgetdestroybycatcher,operatorpvp_bandit_batterykill,operatorpvp_buck_kill,operatorpvp_frost_dbno,operatorpvp_blackbeard_gunshieldblockdamage,operatorpvp_valkyrie_camdeployed,operatorpvp_capitao_lethaldartkills,operatorpvp_echo_enemy_sonicburst_affected,operatorpvp_cazador_assist_kill,operatorpvp_black_mirror_gadget_deployed,operatorpvp_dazzler_gadget_detonate,operatorpvp_caltrop_enemy_affected,operatorpvp_concussionmine_detonate,operatorpvp_concussiongrenade_detonate,operatorpvp_phoneshacked,operatorpvp_attackerdrone_diminishedrealitymode,operatorpvp_tagger_tagdevice_spot,operatorpvp_rush_adrenalinerush,operatorpvp_barrage_killswithturret,operatorpvp_deceiver_revealedattackers,operatorpvp_maverick_wallbreached,operatorpvp_clash_sloweddown,operatorpvp_nomad_airjabdetonate,operatorpvp_kaid_electroclawelectrify,operatorpvp_gridlock_traxdeployed,operatorpvp_nokk_observationtooldeceived,operatorpvp_warden_killswithglasses,operatorpvp_goyo_volcandetonate,operatorpvp_amaru_distancereeled,operatorpvp_kali_gadgetdestroywithexplosivelance,operatorpvp_wamai_gadgetdestroybymagnet,casualpvp_timeplayed,casualpvp_matchwon,casualpvp_matchlost,casualpvp_matchplayed,casualpvp_kills,casualpvp_death,rankedpvp_matchwon,rankedpvp_matchlost,rankedpvp_timeplayed,rankedpvp_matchplayed,rankedpvp_kills,rankedpvp_death,secureareapvp_matchwon,secureareapvp_matchlost,secureareapvp_matchplayed,secureareapvp_bestscore,rescuehostagepvp_matchwon,rescuehostagepvp_matchlost,rescuehostagepvp_matchplayed,rescuehostagepvp_bestscore,plantbombpvp_matchwon,plantbombpvp_matchlost,plantbombpvp_matchplayed,plantbombpvp_bestscore";
        // Only includes casual, ranked and general stats
        internal const string CoreStatisticsVariables = "casualpvp_death:infinite,casualpvp_kills:infinite,casualpvp_matchlost:infinite,casualpvp_matchplayed:infinite,casualpvp_matchwon:infinite,casualpvp_timeplayed:infinite,generalpve_death:infinite,generalpve_kills:infinite,generalpve_matchlost:infinite,generalpve_matchplayed:infinite,generalpve_matchwon:infinite,generalpve_timeplayed:infinite,generalpvp_barricadedeployed:infinite,generalpvp_bulletfired:infinite,generalpvp_bullethit:infinite,generalpvp_dbno:infinite,generalpvp_death:infinite,generalpvp_headshot:infinite,generalpvp_killassists:infinite,generalpvp_kills:infinite,generalpvp_matchlost:infinite,generalpvp_matchplayed:infinite,generalpvp_matchwon:infinite,generalpvp_reinforcementdeploy:infinite,generalpvp_revive:infinite,generalpvp_suicide:infinite,generalpvp_timeplayed:infinite,rankedpvp_death:infinite,rankedpvp_kills:infinite,rankedpvp_matchlost:infinite,rankedpvp_matchplayed:infinite,rankedpvp_matchwon:infinite,rankedpvp_timeplayed:infinite";
        // PvP firefight stats like bullets hit, headshots and kills
        internal const string FirefightStatisticsVariables = "weapontypepvp_kills,weapontypepvp_headshot,weapontypepvp_bulletfired,weapontypepvp_bullethit";
        // Operator-specific stats like kills/deaths, gadget uses, timeplayed etc
        internal const string OperatorStatisticsVariables = "operatorpvp_phoneshacked,operatorpvp_timeplayed,operatorpvp_roundwon,operatorpvp_roundlost,operatorpvp_kills,operatorpvp_death,operatorpvp_maverick_wallbreached,operatorpvp_goyo_volcandetonate,operatorpvp_black_mirror_gadget_deployed,operatorpvp_montagne_shieldblockdamage,operatorpvp_ace_selmadetonate,operatorpvp_glaz_sniperkill,operatorpvp_fuze_clusterchargekill,operatorpvp_frost_dbno,operatorpvp_rush_adrenalinerush,operatorpvp_concussionmine_detonate,operatorpvp_echo_enemy_sonicburst_affected,operatorpvp_wamai_gadgetdestroybymagnet,operatorpvp_doc_teammaterevive,operatorpvp_clash_sloweddown,operatorpvp_caveira_interrogations,operatorpvp_castle_kevlarbarricadedeployed,operatorpvp_capitao_lethaldartkills,operatorpvp_oryx_killsafterdash,operatorpvp_iana_killsafterreplicator,operatorpvp_buck_kill,operatorpvp_blitz_flashedenemy,operatorpvp_bandit_batterykill,operatorpvp_kapkan_boobytrapkill,operatorpvp_ash_bonfirewallbreached,operatorpvp_amaru_distancereeled,operatorpvp_deceiver_revealedattackers,operatorpvp_melusi_sloweddown,operatorpvp_tachanka_turretkill,operatorpvp_thatcher_gadgetdestroywithemp,operatorpvp_thermite_reinforcementbreached,operatorpvp_kali_gadgetdestroywithexplosivelance,operatorpvp_concussiongrenade_detonate,operatorpvp_twitch_gadgetdestroybyshockdrone,operatorpvp_valkyrie_camdeployed,operatorpvp_attackerdrone_diminishedrealitymode,operatorpvp_gridlock_traxdeployed,operatorpvp_hibana_detonate_projectile,operatorpvp_iq_gadgetspotbyef,operatorpvp_cazador_assist_kill,operatorpvp_jager_gadgetdestroybycatcher,operatorpvp_kaid_electroclawelectrify,operatorpvp_caltrop_enemy_affected,operatorpvp_blackbeard_gunshieldblockdamage,operatorpvp_tagger_tagdevice_spot,operatorpvp_barrage_killswithturret,operatorpvp_dazzler_gadget_detonate,operatorpvp_smoke_poisongaskill,operatorpvp_mozzie_droneshacked,operatorpvp_sledge_hammerhole,operatorpvp_mute_gadgetjammed,operatorpvp_rook_armortakenteammate,operatorpvp_nomad_airjabdetonate,operatorpvp_nokk_observationtooldeceived,operatorpvp_pulse_heartbeatspot,operatorpvp_warden_killswithglasses";
        // All time PvP stats like kills/deaths, headshots, match details
        internal const string GeneralStatisticsVariables = "generalpvp_timeplayed,generalpvp_matchplayed,generalpvp_killassists,generalpvp_revive,generalpvp_headshot,generalpvp_penetrationkills,generalpvp_meleekills,generalpvp_matchwon,generalpvp_matchlost,generalpvp_kills,generalpvp_death,generalpvp_bullethit,generalpvp_bulletfired";
        // Queue specific details (casual and ranked)
        internal const string QueueStatisticsVariables = "casualpvp_timeplayed,casualpvp_matchwon,casualpvp_matchlost,casualpvp_matchplayed,casualpvp_kills,casualpvp_death,rankedpvp_matchwon,rankedpvp_matchlost,rankedpvp_timeplayed,rankedpvp_matchplayed,rankedpvp_kills,rankedpvp_death";
        // Objectives related details like bomb/hostage/secure area
        internal const string ObjectiveStatisticsVariables = "secureareapvp_matchwon,secureareapvp_matchlost,secureareapvp_matchplayed,secureareapvp_bestscore,rescuehostagepvp_matchwon,rescuehostagepvp_matchlost,rescuehostagepvp_matchplayed,rescuehostagepvp_bestscore,plantbombpvp_matchwon,plantbombpvp_matchlost,plantbombpvp_matchplayed,plantbombpvp_bestscore";

        internal static readonly Guid Rainbow6S = Guid.Parse("39baebad-39e5-4552-8c25-2c9b919064e2");

        internal static readonly Guid Uplay = Guid.Parse("5172a557-50b5-4665-b7db-e3f2e8c5041d");
        internal static readonly Guid PSN = Guid.Parse("05bfb3f7-6c21-4c42-be1f-97a33fb5cf66");
        internal static readonly Guid XBL = Guid.Parse("98a601e5-ca91-4440-b1c5-753f601a2c90");

        /// <summary>
        /// Build a string of player-based variables.
        /// </summary>
        /// <param name="statistics">
        /// Which statistics are to be used to build the variables line.
        /// </param>
        /// <returns>
        /// A comma-separated string full of variables interpretted from requested statistics.
        /// </returns>
        internal static string StatisticsBuilder(params StatisticsType[] statistics)
        {
            // deduplicate input
            statistics = statistics.Distinct().ToArray();

            // keep distinct variables for returning
            var uniques = new HashSet<string>();
            foreach (var statistic in statistics)
            {
                var variables = GetVariables(statistic);
                foreach (var variable in variables)
                {
                    uniques.Add(variable);
                }
            }

            return string.Join(',', uniques);
        }

        private static string[] GetVariables(StatisticsType statisticsType)
        {
            var line = string.Empty;
            switch (statisticsType)
            {
                case StatisticsType.All:
                    line = AllStatisticsVariables;
                    break;
                case StatisticsType.Core:
                    line = CoreStatisticsVariables;
                    break;
                case StatisticsType.Firefight:
                    line = FirefightStatisticsVariables;
                    break;
                case StatisticsType.Operator:
                    line = OperatorStatisticsVariables;
                    break;
                case StatisticsType.General:
                    line = GeneralStatisticsVariables;
                    break;
                case StatisticsType.Queue:
                    line = QueueStatisticsVariables;
                    break;
                case StatisticsType.Objective:
                    line = ObjectiveStatisticsVariables;
                    break;
            }
            return line.Split(',');
        }

        internal static string PlatformToString(Platform Platform)
        {
            return Platform switch
            {
                Platform.PSN => "psn",
                Platform.Uplay => "uplay",
                Platform.XBL => "xbl",
                _ => throw new Exception("Platform does not exist.")
            };
        }

        internal static string RegionToString(Region Region)
        {
            return Region switch
            {
                Region.APAC => "apac",
                Region.EMEA => "emea",
                Region.NCSA => "ncsa",
                _ => throw new Exception("Region does not exist."),
            };
        }

        internal static Guid PlatformToGuid(Platform Platform)
        {
            return Platform switch
            {
                Platform.PSN => PSN,
                Platform.Uplay => Uplay,
                Platform.XBL => XBL,
                _ => throw new Exception("Platform does not exist."),
            };
        }
    }
}
