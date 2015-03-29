using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesafioGeoAmbiente.Models;

namespace DesafioGeoAmbiente.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {           
            return View();
        }

        [HttpGet]
        public ActionResult Pesquisar()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Pesquisar(string ra)
        {
            IList<Aluno> Alunos = AbrirCsv();

            Aluno aluno = Alunos.FirstOrDefault(a => a.RA == int.Parse(ra));

            if (aluno == null) return View(); 
               
            return View(aluno);
        }

        private IList<Aluno> AbrirCsv()
        {
            IList<Aluno> Alunos = new List<Aluno>();

            var appdata = HttpContext.Server.MapPath("~/App_Data/Alunos.csv"); 

            StreamReader rd = new StreamReader(appdata);
            string linha = null;
            //string[] linhaseparada = null;
            while ((linha = rd.ReadLine()) != null)
            {
                var colunas = linha.Split(';');
                Aluno aluno = new Aluno();
                aluno.Nome = colunas[0];
                aluno.RA = int.Parse(colunas[1]);
                aluno.lat = double.Parse(colunas[2]);
                aluno.lon = double.Parse(colunas[3]);

                Alunos.Add(aluno);

            }
            rd.Close();

            return Alunos;
        }
    }
}