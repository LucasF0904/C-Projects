using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;
namespace revisaoPOO
{
    public class ClassConteudo
    {
        public int cod_cont { get; set; }
        public string descricao_cont { get; set; }
        public int cargaHoraria_cont { get; set; }

       
        public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "curso");
   
   public void cadastrarcurso()
        {
       try
       {

           string valores = string.Format(@"'{0}','{1}','{2}'", cod_cont, descricao_cont, cargaHoraria_cont);
           dao.Inserir_Registro("tbl_conteudo",valores);
       }
       catch( Exception ex)
       {
           throw ex;
       }

        }

      public void Excluircurso()
   {
        try
        {
            dao.Deletar_Registro("tbl_conteudo", "cod_cont = " + cod_cont);
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    public void AlterarCurso()
    {
        try
        {
           string valores = string.Format("'{0}','{1}','{2}'", cod_cont, descricao_cont, cargaHoraria_cont);
           dao.Inserir_Registro("tbl_curso", valores, "cod_curso = " + cod_cont);
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
        public DataTable Visualizarcurso()
        {
            try
            {
                return dao.Visualizar_Registro("tbl_conteudo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
    }
    
    }
    
    
    
 }
