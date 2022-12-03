using ModdingUtils.Extensions;
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
    internal class MegaGun : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            UnityEngine.Debug.Log($"[{KudlikCarsd.ModInitials}][Card] {GetTitle()} has been setup.");
            gun.damage = 6.9f;
            gun.projectileSize = 6.9f;
            gun.projectileSpeed = 2.00f;
            gun.reloadTime = 2f;
            
    }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
            UnityEngine.Debug.Log($"[{KudlikCarsd.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
            gunAmmo.maxAmmo = 1;

        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
            UnityEngine.Debug.Log($"[{KudlikCarsd.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");


        }

        protected override string GetTitle()
        {
            return "MegaGun";

        }
        protected override string GetDescription()
        {
            return "Why have a minigun when you can have a mega one!";

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
                    stat = "Bullet Speed",
                    amount = "+420%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Damage",
                    amount = "+69%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Max Ammo",
                    amount = "1",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Reload Time",
                    amount = "-200%",
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
