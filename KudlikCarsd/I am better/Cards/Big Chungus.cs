using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace KudlikCarsd.Cards
{
    internal class BigChungus : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            UnityEngine.Debug.Log($"[{KudlikCarsd.ModInitials}][Card] {GetTitle()} has been setup.");
            statModifiers.sizeMultiplier = 6.9f;
            statModifiers.health = 4.20f;
            statModifiers.movementSpeed = 0.69f;
            cardInfo.allowMultiple = false;


        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
            UnityEngine.Debug.Log($"[{KudlikCarsd.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");


        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
            UnityEngine.Debug.Log($"[{KudlikCarsd.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");


        }

        protected override string GetTitle()
        {
            return "Big Chungus";

        }
        protected override string GetDescription()
        {
            return "Chunky and funky";

        }
        protected override GameObject? GetCardArt()
        {
            return null;

        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;

        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Size",
                    amount = "+690%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Health",
                    amount = "+420%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Speed",
                    amount = "-69%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.TechWhite;
        }
        public override string GetModName()
        {
            return KudlikCarsd.ModInitials;
        }
    }
}
