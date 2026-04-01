using System;
using System.Collections.Generic;
using System.Text;

namespace FSOServer.Packets
{
    public enum PacketType : ushort
    {
        Incoming_LoginRequest = 100, //Requesting login, credentials included
        Incoming_CharacterListRequest = 101, //Requesting character list, read account and send character list back
        Incoming_MapDataRequest = 102, //Request map data. Send Tiles,NPC,Other characters, player character
        Incoming_MapTransitionReuqest = 103, //Reached Edge of map, requesting transition
        Incoming_CharacterMoveRequest = 104, //Moving character, send movement data 
        Incoming_InteractRequest = 105, //Interacting with something, send interaction data and target data
        Incoming_AttackRequest = 106, //Attacking something, send attack data and target data
        Incoming_WhosOnlineRequest = 107, //Requesting list of online players, send list of online players back
        Incoming_FriendsOnlineRequest = 108, //Requesting list of online friends, send list of online friends back
        Incoming_InventorySwapRequest = 109, //Swapping items in inventory, send swap data
        Incoming_InventoryDropRequest = 110, //Dropping item from inventory, send drop data 
        Incoming_InventoryEquipRequest = 111, //Equipping item from inventory, send equip data
        Incoming_InventoryUnequipRequest = 112, //Unequipping item from equip slot, send unequip data 
        Incoming_ChatMessageRequest = 113, //Sending chat message, send message data 
        Incoming_Editor_SaveMap = 114, //Save Map request from cleint map editor
    }
}
