using CitizenFX.Core;
using CitizenFX.Core.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Friend
{
    public class Main : BaseScript
    {
        public Main()
        {
            API.RegisterCommand("test", new Action(TestCommand), false); // Creates a new command.
        }
        private async void TestCommand()
        {
            Ped player = Game.Player.Character; // Figures out who the player in the game is.
            API.RequestModel((uint)PedHash.Security01SMM); // Game needs to request the model first.
            while (!API.HasModelLoaded((uint)PedHash.Security01SMM)) // While the model has not loaded, it waits a 10th of a second, then will continue.
            {
                Debug.WriteLine("Waiting for model to load");
                await BaseScript.Delay(100);
            }
            Ped bodyguard = await World.CreatePed(PedHash.Security01SMM, player.Position + (player.ForwardVector * 2)); // Creates the ped, model, and all the information needed for it to spawn.
            bodyguard.Task.LookAt(player); 
            API.SetPedAsGroupMember(bodyguard.Handle, API.GetPedGroupIndex(player.Handle));
            API.SetPedCombatAbility(bodyguard.Handle, 2);
            API.GiveWeaponToPed(bodyguard.Handle, (uint)WeaponHash.AssaultRifleMk2, 500, false, true);

        }
    }
}
