using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ARareItemSwapJPANs.Commands
{
    public class ModCallCommand
    {
        public string name;
        public List<string> alias;

        public ModCallCommand(params string[] aliases)
        {

            if (aliases == null || aliases.Length == 0)
            {
                alias = null;
                this.name = null;
            }
            else
            {
                this.alias = new List<string>();
                this.alias.AddRange(aliases);
                this.name = alias[0];
                this.alias.RemoveAt(0);
            }
        }

        public bool IsThisCommand(string command)
        {
//            ARareItemSwapJPANs.LogError(command, name);
            if (command.ToLower().Equals(name.ToLower()))
                return true;
            if(alias != null)
            {
                foreach(string s in alias)
                {
                    if (command.ToLower().Equals(s.ToLower()))
                        return true;
                }
            }
            return false;
        }

        public virtual string Help()
        {
            return "";
        }

        public virtual object Run(object[] args, int start = 1)
        {
            return true;
        }

        public static List<string> getListOfStringFromObjects(object[] args, int v)
        {
            List<string> ans = new List<string>();
            for (int i = v; i < args.Length; i++)
            {
                if (args[i] is List<string>)
                {
                    ans.AddRange((args[i]) as List<string>);
                    continue;
                }
                else if (args[i] is string[])
                {
                    ans.AddRange((args[i]) as string[]);
                    continue;
                }
                else if (args[i] is string)
                {
                    ans.Add((args[i]) as string);
                    continue;
                }
                else
                {

                }
            }
            return ans;
        }

        public static int? getIntFromObject(object o)
        {
            if (o == null)
                return null;
            if (o as int? != null)
                return o as int?;
            if (o as string != null)
            {
                int res;
                if (Int32.TryParse(o as string, out res))
                    return res;
            }
            return null;
        }

        public static long? getLongFromObject(object o)
        {
            if (o == null)
                return null;
            if (o as long? != null)
                return o as long?;
            if (o as string != null)
            {
                long res;
                if (Int64.TryParse(o as string, out res))
                    return res;
            }
            return null;
        }

        public static int? getItemTypeFromObject(object o)
        {
            if (o == null)
                return null;
            if (o is string)
                return ARareItemSwapJPANs.getItemTypeFromTag(o as string);
            else if (o is Item)
                return (o as Item).type;
            else if (o is ModItem)
                return (o as ModItem).item.type;
            else if (o is int)
                return (int)o;
            return null;
        }

        public static Item getItemFromObject(object o)
        {
            if (o == null)
                return null;
            if (o is string)
                return ARareItemSwapJPANs.getItemFromTag(o as string);
            else if (o is Item)
                return (o as Item);
            else if (o is ModItem)
                return (o as ModItem).item;
            else if (o is int)
            {
                Item itm = new Item();
                itm.SetDefaults((int)o);
                return itm;
            }
            return null;
        }

        public static NPC getNPCFromObject(object o)
        {
            if (o == null)
                return null;
            if (o is string)
                return ARareItemSwapJPANs.getNPCFromTag(o as string);
            else if (o is NPC)
                return (o as NPC);
            else if (o is ModNPC)
                return (o as ModNPC).npc;
            else if (o is int)
            {
                NPC npc = new NPC();
                npc.SetDefaults((int)o);
                return npc;
            }
            return null;
        }


        public static Player getPlayerFromObject(object o)
        {
            if (o == null)
                return null;
            if (o is int && ((int)o < 256))
                return Main.player[(int)o];
            if (o is Player)
                return o as Player;
            return null;
        }



    }
}
