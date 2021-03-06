﻿using SmartClass.DAL;
using SmartClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartClass.BLL
{
    public class EquipamentoBLL
    {
        EquipamentoDAL dal = new EquipamentoDAL();

        public void Inserir(String pDsEquipamento)
        {
            dal.Inserir(pDsEquipamento);
        }

        public void Alterar(Equipamento eqpto)
        {
            dal.Alterar(eqpto);
        }

        public void Excluir(int pCdEquipamento)
        {
            dal.Excluir(pCdEquipamento);
        }

        public List<Equipamento> ListarEquipamentos(int pCdSala, String pConnectionString)
        {
            return dal.ListarEquipamentos(pCdSala, pConnectionString);
        }

        public bool ligarEquipamento(int pCdEquipamento, String pConnectionString)
        {
            return dal.ligarEquipamento(pCdEquipamento, pConnectionString);

        }
    }
}
