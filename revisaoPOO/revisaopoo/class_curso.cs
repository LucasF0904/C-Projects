using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace revisaoPOO
{
    public class class_curso
    {
        public int cod_curso { get; set; }
        public int cod_conteudo { get; set; }
        public DateTime dataInicio_curso { get; set; }
        public double duracao_curso { get; set; }
        public decimal valor_curso { get; set; }

             public Class_DAL_Mysql dao = new Class_DAL_Mysql("localhost", "root", "", "curso");
   
   public void cadastrarcurso()
        {
       try
       {

           string valores = string.Format("'{0}','{1}','{2}','{3}','{4}'", cod_curso, cod_conteudo, dataInicio_curso.ToString("yyyy/mm/dd"), duracao_curso.ToString().Replace(',','.'), valor_curso);
           dao.Inserir_Registro("tbl_curso",valores);
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
            dao.Deletar_Registro("tbl_curso", "cod_curso = " + cod_curso);
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

            string valores = string.Format("'{0}','{1}','{2}','{3}','{4}'", cod_curso, cod_conteudo, dataInicio_curso.ToString("yyyy/mm/dd"), duracao_curso.ToString().Replace(',', '.'), valor_curso);
            dao.Inserir_Registro("tbl_curso", valores, "cod_curso = " + cod_curso);
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
                return dao.Visualizar_Registro("tbl_curso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
    }
    
    }
}