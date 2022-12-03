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
    internal class Carrrrrd : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            UnityEngine.Debug.Log($"[{KudlikCarsd.ModInitials}][Card] {GetTitle()} has been setup.");
            statModifiers.movementSpeed = 4.20f;
            statModifiers.health = 1.69f;
            statModifiers.gravity = +4.20f;
            
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
            return "Carrrrrd";

        }
        protected override string GetDescription()
        {
            return "Vroom vroom";

        }
        protected override GameObject? GetCardArt()
        {
            return null;

        }

        private T Assets<T>(string v)
        {
            throw new NotImplementedException();
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
                    stat = "Speed",
                    amount = "+420%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }, 
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Health",
                    amount = "+69%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },   
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Gravity",
                    amount = "+420%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.ColdBlue;
        }
        public override string GetModName()
        {
            return KudlikCarsd.ModInitials;
        }
    }
}
