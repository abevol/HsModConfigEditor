using BepInEx.Logging;
using System.ComponentModel;
using HsMod.GameDefines;

namespace HsMod
{
    namespace GameDefines
    {
        public enum OSCategory
        {
            PC = 1,
            Mac,
            iOS,
            Android
        }

        public class AlertPopup
        {
            public enum Response
            {
                OK,
                CONFIRM,
                CANCEL
            }
        }

        public enum TAG_RARITY
        {
            INVALID,
            COMMON,
            FREE,
            RARE,
            EPIC,
            LEGENDARY
        }

        public enum TAG_PREMIUM
        {
            NORMAL,
            GOLDEN,
            DIAMOND,
            SIGNATURE,
            MAX
        }

        public enum ScreenCategory
        {
            PHONE = 1,
            MINI_TABLET,
            TABLET,
            PC
        }

        public enum Locale
        {
            UNKNOWN = -1,
            enUS = 0,
            enGB = 1,
            frFR = 2,
            deDE = 3,
            koKR = 4,
            esES = 5,
            esMX = 6,
            ruRU = 7,
            zhTW = 8,
            zhCN = 9,
            itIT = 10,
            ptBR = 11,
            plPL = 12,
            jaJP = 14,
            thTH = 15,
        }

        public enum BoosterDbId
        {
            INVALID,
            CLASSIC,
            GOBLINS_VS_GNOMES = 9,
            THE_GRAND_TOURNAMENT,
            OLD_GODS,
            FIRST_PURCHASE_OLD = 17,
            SIGNUP_INCENTIVE,
            MEAN_STREETS,
            UNGORO,
            FROZEN_THRONE,
            GOLDEN_CLASSIC_PACK = 23,
            KOBOLDS_AND_CATACOMBS = 30,
            WITCHWOOD,
            THE_BOOMSDAY_PROJECT = 38,
            RASTAKHANS_RUMBLE = 40,
            MAMMOTH_BUNDLE,
            DALARAN = 49,
            FIRST_PURCHASE = 181,
            ULDUM = 128,
            DRAGONS = 347,
            BLACK_TEMPLE = 423,
            SCHOLOMANCE = 468,
            STANDARD_HUNTER = 470,
            YEAR_OF_DRAGON = 498,
            STANDARD_MAGE = 545,
            THE_BARRENS = 553,
            STORMWIND = 602,
            GOLDEN_SCHOLOMANCE,
            DARKMOON_FAIRE = 616,
            MERCENARIES = 629,
            STANDARD_DRUID = 631,
            STANDARD_PALADIN,
            STANDARD_WARRIOR,
            STANDARD_PRIEST,
            STANDARD_ROGUE,
            STANDARD_SHAMAN,
            STANDARD_WARLOCK,
            STANDARD_DEMONHUNTER,
            GOLDEN_DARKMOON_FAIRE = 643,
            ALTERAC_VALLEY = 665,
            GOLDEN_THE_BARRENS = 686,
            YEAR_OF_PHOENIX = 688,
            THE_SUNKEN_CITY = 694,
            STANDARD_PACK = 713,
            WILD_PACK,
            GOLDEN_STANDARD_PACK = 716,
            REVENDRETH = 729,
            STORMWIND_GOLDEN = 737,
            RETURN_OF_THE_LICH_KING = 821,
            ALTERAC_VALLEY_GOLDEN = 841,
            PATH_OF_ARTHAS = 903,
            BATTLE_OF_THE_BANDS = 854,
            TITANS = 819,
            CAVERNS_OF_TIME = 894,
            WILD_WEST = 922,
            GOLDEN_FESTIVAL_OF_LEGENDS = 932,
            WILD_WEST2 = 944,
            WHIZBANGS_WORKSHOP = 933,
            ISLAND_VACATION = 941,
            SPACE = 965
        }
    }

    public class Utils
    {
        public enum CardState
        {
            [Description("默认（不做修改）")]
            Default,
            [Description("仅友方有效")]
            OnlyMy,
            [Description("全部生效")]
            All,
            [Description("禁用特效")]
            Disabled
        }

        public enum AlertPopupResponse
        {
            OK = AlertPopup.Response.OK,
            CONFIRM = AlertPopup.Response.CONFIRM,
            CANCEL = AlertPopup.Response.CANCEL,
            YES,
            DONOTHING
        }
        public enum ConfigTemplate
        {
            [Description("默认")]
            DoNothing,
            [Description("挂机")]
            AwayFromKeyboard,
            [Description("反挂机")]
            AntiAwayFromKeyboard
        }
        public enum BuyAdventureTemplate
        {
            [Description("默认")]
            DoNothing,
            [Description("纳克萨玛斯的诅咒")]
            BuyNAX,
            [Description("黑石山的火焰")]
            BuyBRM,
            [Description("探险者协会")]
            BuyLOE,
            [Description("卡拉赞之夜")]
            BuyKara
        }

        public enum CardRarity    // 卡牌稀有度
        {
            COMMON = TAG_RARITY.COMMON,
            RARE = TAG_RARITY.RARE,
            EPIC = TAG_RARITY.EPIC,
            LEGENDARY = TAG_RARITY.LEGENDARY
        }
        public enum DevicePreset
        {
            Default,
            iPad,
            iPhone,
            Phone,
            Tablet,
            HuaweiPhone,
            Custom
        }

        public static void MyLogger(LogLevel level, object message)
        {
            var myLogSource = BepInEx.Logging.Logger.CreateLogSource(PluginInfo.PLUGIN_GUID + ".MyLogger");
            myLogSource.Log(level, message);
            BepInEx.Logging.Logger.Sources.Remove(myLogSource);
        }

    }
}
