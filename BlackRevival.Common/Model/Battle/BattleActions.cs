﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevival.Common.Model
{
	// Token: 0x020012DB RID: 4827
	public enum BattleActionErrorType
	{
		// Token: 0x040054AB RID: 21675
		UNKNOWN_ERROR = 4000,
		// Token: 0x040054AC RID: 21676
		ALREADY_HACKED,
		// Token: 0x040054AD RID: 21677
		ALREADY_JOINED,
		// Token: 0x040054AE RID: 21678
		ALREADY_MAX_HEALTH,
		// Token: 0x040054AF RID: 21679
		ALREADY_MAX_STAMINA,
		// Token: 0x040054B0 RID: 21680
		ALREADY_RESTING,
		// Token: 0x040054B1 RID: 21681
		DEAD_CHARACTER,
		// Token: 0x040054B2 RID: 21682
		INSUFFICIENT_GRADE,
		// Token: 0x040054B3 RID: 21683
		INVENTORY_IS_FULL,
		// Token: 0x040054B4 RID: 21684
		LACK_OF_QUANTITY,
		// Token: 0x040054B5 RID: 21685
		LACK_OF_STAMINA,
		// Token: 0x040054B6 RID: 21686
		NO_BATTERY_EXISTS,
		// Token: 0x040054B7 RID: 21687
		NO_BATTLE_EXISTS,
		// Token: 0x040054B8 RID: 21688
		NO_BATTLE_WAITING_ROOM_EXISTS,
		// Token: 0x040054B9 RID: 21689
		NO_DEAD_ENEMY_EXISTS,
		// Token: 0x040054BA RID: 21690
		NO_DEAD_MONSTER_EXISTS,
		// Token: 0x040054BB RID: 21691
		NO_ENEMY_EXISTS,
		// Token: 0x040054BC RID: 21692
		NO_ITEM_EXISTS,
		// Token: 0x040054BD RID: 21693
		NO_MONSTER_EXISTS,
		// Token: 0x040054BE RID: 21694
		NO_PASSCODE_EXISTS,
		// Token: 0x040054BF RID: 21695
		NO_RADAR_EXISTS,
		// Token: 0x040054C0 RID: 21696
		NO_ROOM_EXISTS,
		// Token: 0x040054C1 RID: 21697
		NO_SPECIALTY_EXISTS,
		// Token: 0x040054C2 RID: 21698
		NO_USER_EXISTS,
		// Token: 0x040054C3 RID: 21699
		NOT_ALLOWED_FIELD_TYPE,
		// Token: 0x040054C4 RID: 21700
		NOT_WOUNDED,
		// Token: 0x040054C5 RID: 21701
		ONLY_AVAILABLE_IN_LABORATORY,
		// Token: 0x040054C6 RID: 21702
		PARAMETER_IS_MISSED,
		// Token: 0x040054C7 RID: 21703
		RESTRICTED_FIELD,
		// Token: 0x040054C8 RID: 21704
		ROOM_IS_FULL,
		// Token: 0x040054C9 RID: 21705
		ROOM_IS_NOT_PLAYING,
		// Token: 0x040054CA RID: 21706
		ROOM_START_FAILED,
		// Token: 0x040054CB RID: 21707
		UNABLE_TO_ENHANCE,
		// Token: 0x040054CC RID: 21708
		UNABLE_TO_MIX,
		// Token: 0x040054CD RID: 21709
		UNDER_COOLDOWN,
		// Token: 0x040054CE RID: 21710
		UNTHROWABLE_WEAPON_TYPE,
		// Token: 0x040054CF RID: 21711
		DEAD_ENEMY_CHARACTER,
		// Token: 0x040054D0 RID: 21712
		DEAD_ENEMY_MONSTER,
		// Token: 0x040054D1 RID: 21713
		NO_WOUND,
		// Token: 0x040054D2 RID: 21714
		NO_REMEMBER_ITEM,
		// Token: 0x040054D3 RID: 21715
		DO_NOT_SEARCH = 4042,
		// Token: 0x040054D4 RID: 21716
		CANNOT_SAME_USER,
		// Token: 0x040054D5 RID: 21717
		NOT_LAST_TARGET,
		// Token: 0x040054D6 RID: 21718
		NO_MORE_USE,
		// Token: 0x040054D7 RID: 21719
		NOT_ALLOWED_CHANGE,
		// Token: 0x040054D8 RID: 21720
		NOT_ALLOWED_MOVE,
		// Token: 0x040054D9 RID: 21721
		INCORRERT_WEAPON_TYPE = 4040,
		// Token: 0x040054DA RID: 21722
		NO_ADMIN = 4100,
		// Token: 0x040054DB RID: 21723
		TO_LATE_HACK = 4048,
		// Token: 0x040054DC RID: 21724
		NOT_ALLOWED_ATTACK,
		// Token: 0x040054DD RID: 21725
		NOT_ALLOWED_SKILL,
		// Token: 0x040054DE RID: 21726
		ALREADY_GOT_START_ITEM,
		// Token: 0x040054DF RID: 21727
		NOT_ALLOWED_REST,
		// Token: 0x040054E0 RID: 21728
		NO_JOIN_AGAIN = 4098,
		// Token: 0x040054E1 RID: 21729
		NOT_ALLOWED_FREE_CHANGE,
		// Token: 0x040054E2 RID: 21730
		FAILED_TO_REQUEST_AI = 4101,
		// Token: 0x040054E3 RID: 21731
		NOT_ENOUGH_HEALTH = 4103,
		// Token: 0x040054E4 RID: 21732
		NO_MORE_ENHANCE = 4102,
		// Token: 0x040054E5 RID: 21733
		NOT_AVAILABLE_COMBAT_SKILL = 4104,
		// Token: 0x040054E6 RID: 21734
		NOT_ENOUGH_STACK,
		// Token: 0x040054E7 RID: 21735
		NOT_FISHING_AREA = 4053,
		// Token: 0x040054E8 RID: 21736
		ROOM_IS_PLAYING = 4108,
		// Token: 0x040054E9 RID: 21737
		NO_BATTLE_SEAT = 4106,
		// Token: 0x040054EA RID: 21738
		NO_BATTLE_MATCHING_INFO,
		// Token: 0x040054EB RID: 21739
		NOT_ALLOWED_SEARCH = 4112,
		// Token: 0x040054EC RID: 21740
		CANNOT_EQUIP_WEAPON_TYPE = 4114,
		// Token: 0x040054ED RID: 21741
		CANNOT_EVOLUTION,
		// Token: 0x040054EE RID: 21742
		CANNOT_EQUIP_CHANGE,
		// Token: 0x040054EF RID: 21743
		INVALID_INGAME_SUPPLIES_TYPE = 4118,
		// Token: 0x040054F0 RID: 21744
		NOT_INGAME_SUPPLIES_TIME,
		// Token: 0x040054F1 RID: 21745
		ALREADY_TAKEN_INGAME_SUPPLIES,
		// Token: 0x040054F2 RID: 21746
		NOT_ALLOWED_ATTACK_PEACE_ZONE,
		// Token: 0x040054F3 RID: 21747
		STILL_WAITING_TIME = 4123,
		// Token: 0x040054F4 RID: 21748
		NOT_EXIST_STARTING_ITEM,
		// Token: 0x040054F5 RID: 21749
		CANNOT_CHANGE_STARTING_ITEM,
		// Token: 0x040054F6 RID: 21750
		NO_EQUIPED_ITEM,
		// Token: 0x040054F7 RID: 21751
		CANNOT_MAKE_ITEM,
		// Token: 0x040054F8 RID: 21752
		CANNOT_UPLOAD_ITEM,
		// Token: 0x040054F9 RID: 21753
		CANNOT_UNEQUIP_ITEM,
		// Token: 0x040054FA RID: 21754
		ALREADY_REVIVE = 5001,
		// Token: 0x040054FB RID: 21755
		NO_MORE_REVIVE,
		// Token: 0x040054FC RID: 21756
		TEAM_INVENTORY_IS_FULL,
		// Token: 0x040054FD RID: 21757
		NO_TEAM_ITEM_EXISTS
	}

	public enum BattleActionLogSequence
	{
		// Token: 0x0400548B RID: 21643
		None,
		// Token: 0x0400548C RID: 21644
		Cast,
		// Token: 0x0400548D RID: 21645
		BloodSucking,
		// Token: 0x0400548E RID: 21646
		Defence,
		// Token: 0x0400548F RID: 21647
		DefenceOnlyMe,
		// Token: 0x04005490 RID: 21648
		Both,
		// Token: 0x04005491 RID: 21649
		Debuff,
		// Token: 0x04005492 RID: 21650
		StackAndDuration,
		// Token: 0x04005493 RID: 21651
		StackAndCooltime,
		// Token: 0x04005494 RID: 21652
		UseItem
	}

}
