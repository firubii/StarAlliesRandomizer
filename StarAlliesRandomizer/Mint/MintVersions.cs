﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarAlliesRandomizer.Util;

namespace StarAlliesRandomizer.Mint
{
    public static class MintVersions
    {
        public static Dictionary<byte[], Opcode[]> Versions = new Dictionary<byte[], Opcode[]>(new ByteArrayComparer())
        {
            {
                //Kirby Star Allies
                //Super Kirby Clash
                new byte[] { 2,1,5,1 },
                new Opcode[] {
                    new Opcode("nop",    new string[] {}),
                    new Opcode("ldsrzr", new string[] {"rz"}),
                    new Opcode("ldsrbt", new string[] {"rz"}),
                    new Opcode("ldsrc4", new string[] {"rz","vint"}),
                    new Opcode("ldsrca", new string[] {"rz","vstr"}),
                    new Opcode("ldsrsr", new string[] {"rz","rx"}),
                    new Opcode("ldsr2",  new string[] {"rz","sx","sy"}),
                    new Opcode("ldsrsa", new string[] {}),
                    new Opcode("ldsrsv", new string[] {"rz","vxref"}),
                    new Opcode("ldsra4", new string[] {"rz","rx"}),
                    new Opcode("ldofa4", new string[] {"rz","rx","yxref"}),
                    new Opcode("ldsrap", new string[] {"rz","rx"}),
                    new Opcode("ldofap", new string[] {"rz","rx","yxref"}),
                    new Opcode("ldsrsz", new string[] {"rz","vxref"}),
                    new Opcode("ldsrfa", new string[] {"rz","vxref"}),
                    new Opcode("ldtype", new string[] {"rz","vxref"}),
                    new Opcode("ldmrp",  new string[] {"rz","rx"}),
                    new Opcode("stsra4", new string[] {"rz","rx"}),
                    new Opcode("stofa4", new string[] {"rx","rz","yxref"}),
                    new Opcode("stsrap", new string[] {"rz","rx"}),
                    new Opcode("stofap", new string[] {"rx","rz","yxref"}),
                    new Opcode("stsvsr", new string[] {"rz","vxref"}),
                    new Opcode("addi32", new string[] {"rz","sx","sy"}),
                    new Opcode("subi32", new string[] {"rz","sx","sy"}),
                    new Opcode("muls32", new string[] {"rz","sx","sy"}),
                    new Opcode("divs32", new string[] {"rz","sx","sy"}),
                    new Opcode("mods32", new string[] {"rz","sx","sy"}),
                    new Opcode("mulu32", new string[] {"rz","sx","sy"}),
                    new Opcode("divu32", new string[] {"rz","sx","sy"}),
                    new Opcode("modu32", new string[] {"rz","sx","sy"}),
                    new Opcode("inci32", new string[] {"rz"}),
                    new Opcode("deci32", new string[] {"rz"}),
                    new Opcode("negs32", new string[] {"rz","rx"}),
                    new Opcode("addf32", new string[] {"rz","sx","sy"}),
                    new Opcode("subf32", new string[] {"rz","sx","sy"}),
                    new Opcode("mulf32", new string[] {"rz","sx","sy"}),
                    new Opcode("divf32", new string[] {"rz","sx","sy"}),
                    new Opcode("incf32", new string[] {"rz"}),
                    new Opcode("decf32", new string[] {"rz"}),
                    new Opcode("negf32", new string[] {"rz","rx"}),
                    new Opcode("lts32",  new string[] {"rz","sx","sy"}),
                    new Opcode("les32",  new string[] {"rz","sx","sy"}),
                    new Opcode("ltu32",  new string[] {"rz","sx","sy"}),
                    new Opcode("leu32",  new string[] {"rz","sx","sy"}),
                    new Opcode("eqi32",  new string[] {"rz","sx","sy"}),
                    new Opcode("nei32",  new string[] {"rz","sx","sy"}),
                    new Opcode("ltf32",  new string[] {"rz","sx","sy"}),
                    new Opcode("lef32",  new string[] {"rz","sx","sy"}),
                    new Opcode("eqf32",  new string[] {"rz","sx","sy"}),
                    new Opcode("nef32",  new string[] {"rz","sx","sy"}),
                    new Opcode("ltcmp",  new string[] {"rz","rx"}),
                    new Opcode("lecmp",  new string[] {"rz","rx"}),
                    new Opcode("eqbool", new string[] {"rz","sx","sy"}),
                    new Opcode("nebool", new string[] {"rz","sx","sy"}),
                    new Opcode("eqptr",  new string[] {"rz","sx","sy"}),
                    new Opcode("neptr",  new string[] {"rz","sx","sy"}),
                    new Opcode("eqstr",  new string[] {"rz","strx","stry"}),
                    new Opcode("nestr",  new string[] {"rz","strx","stry"}),
                    new Opcode("eqwstr", new string[] {"rz","strx","stry"}),
                    new Opcode("newstr", new string[] {"rz","strx","stry"}),
                    new Opcode("astidx", new string[] {"rz","rx"}),
                    new Opcode("andi32", new string[] {"rz","sx","sy"}),
                    new Opcode("ori32",  new string[] {"rz","sx","sy"}),
                    new Opcode("xori32", new string[] {"rz","sx","sy"}),
                    new Opcode("nti32",  new string[] {"rz","rx"}),
                    new Opcode("ntbool", new string[] {"rz","rx"}),
                    new Opcode("slli32", new string[] {"rz","sx","sy"}),
                    new Opcode("slri32", new string[] {"rz","sx","sy"}),
                    new Opcode("jmp",    new string[] {"v"}, Action.Jump),
                    new Opcode("jmppos", new string[] {"rz","v"}, Action.Jump),
                    new Opcode("jmpneg", new string[] {"rz","v"}, Action.Jump),
                    new Opcode("fenter", new string[] {"z","x","y"}),
                    new Opcode("fleave", new string[] {"ry"}, Action.Return),
                    new Opcode("call",   new string[] {"rz","vxref"}),
                    new Opcode("callnv", new string[] {"rz","vxref"}),
                    new Opcode("calltv", new string[] {"rz","vxref"}),
                    new Opcode("calltr", new string[] {"rz","vxref"}),
                    new Opcode("vcal",   new string[] {"rz","rx","yxref"}),
                    new Opcode("ecall",  new string[] {"z","x","y"}),
                    new Opcode("yield",  new string[] {"rz"}),
                    new Opcode("mcopy",  new string[] {"rz","rx","ry"}),
                    new Opcode("mcopys", new string[] {"rz","rx","yxref"}),
                    new Opcode("mzeros", new string[] {"rz","vxref"}),
                    new Opcode("sppsh",  new string[] {"rz","vxref"}),
                    new Opcode("sppshz", new string[] {"rz","vxref"}),
                    new Opcode("sppop",  new string[] {"rz","vxref"}),
                    new Opcode("addofs", new string[] {"rz","vxref"}),
                    new Opcode("ldaddr", new string[] {"rz","rx","yxref"}),
                    new Opcode("arpshz", new string[] {"rz"}),
                    new Opcode("aridx",  new string[] {"rz","rx"}),
                    new Opcode("arpop",  new string[] {"rz","rx"}),
                    new Opcode("arcopy", new string[] {"rz","rx","ry"}),
                    new Opcode("wapshz", new string[] {"rz","vxref"}),
                    new Opcode("waidx",  new string[] {"rz","rx","ry"}),
                    new Opcode("wapop",  new string[] {"rz","vxref"}),
                    new Opcode("cts32f", new string[] {"rz","rx"}),
                    new Opcode("cts32u", new string[] {"rz","rx"}),
                    new Opcode("ctu32s", new string[] {"rz","rx"}),
                    new Opcode("ctu32f", new string[] {"rz","rx"}),
                    new Opcode("ctf32s", new string[] {"rz","rx"}),
                    new Opcode("ctf32u", new string[] {"rz","rx"}),
                    new Opcode("ctis",   new string[] {"rz","vxref"}),
                    new Opcode("ctobja", new string[] {"rz","vxref"}),
                    new Opcode("obnew",  new string[] {"rz","vxref"}),
                    new Opcode("obflag", new string[] {"rz","vint"}),
                    new Opcode("obdel",  new string[] {"rz","vxref"}),
                    new Opcode("obname", new string[] {"rz","rx"}),
                    new Opcode("enmstr", new string[] {"rz","vxref"})
                }
            }
        };
    }
}
