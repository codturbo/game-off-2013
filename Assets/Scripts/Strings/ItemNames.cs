﻿using UnityEngine;
using System.Collections;

/*
 * This string class allows us to look up an item in an
 * inventory by name. These strings must match the itemNames
 * on our Items/ prefabs.
 */
public class ItemNames
{
	// Meter Upgrades
	public static string RED_METER_UPGRADE = "RedMeterUpgrade";
	public static string GREEN_METER_UPGRADE = "GreenMeterUpgrade";
	public static string BLUE_METER_UPGRADE = "BlueMeterUpgrade";
	
	// Magnet Upgrades
	public static string RED_MAGNET = "RedMagnet";
	public static string GREEN_MAGNET = "GreenMagnet";
	public static string BLUE_MAGNET = "BlueMagnet";
	
	// Ability Upgrades
	public static string LASER_EFFICIENCY_UPGRADE = "BetterLaser";
	public static string SHIELD_STRENGTH_UPGRADE = "StrongerShields";
	public static string SLOWER_MOVESPEED_UPGRADE = "BetterReflexes";
	
	// Power Upgrades
	public static string RED_POWER_UPGRADE = "RedPowerUpgrade";
	public static string GREEN_POWER_UPGRADE = "GreenPowerUpgrade";
	public static string BLUE_POWER_UPGRADE = "BluePowerUpgrade";
}
