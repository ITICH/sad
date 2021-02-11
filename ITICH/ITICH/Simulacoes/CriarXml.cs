using ITICH.ConecaoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ITICH.Simulacoes
{
    class CriarXml
    {
        public static string CriarXML (string dt)//metodo que cria o ficheiro XML e guarda localmente
        {
            
            string idParque = "SELECT P.id_parque, P.nome_parque FROM Parques_cientificos P WHERE P.e_mail = '" + dt + "'";
            Console.WriteLine(idParque);
            DataTable id = ConecaoSQLServer.ExecutaSql(idParque);
            int id1 = Int32.Parse(id.Rows[0][0].ToString());
            Console.WriteLine("\n");
            //query que busca a morada
            string queryLocal = "SELECT L.morada FROM Parques_cientificos P, Localizacao L WHERE P.id_localizacao = '" + id1 + "'";
            DataTable local = ConecaoSQLServer.ExecutaSql(queryLocal);
            string l = local.Rows[0][0].ToString();
            //query que busca a fase
            string queryFase = "SELECT F.nome_fase FROM Parques_cientificos P, Fases_desenvolvimento F WHERE P.id_fase_de_desenvolvimento = F.id_fase_desenvolvimento AND P.id_parque = '" + id1 + "'";
            DataTable fase = ConecaoSQLServer.ExecutaSql(queryFase);
            string f = fase.Rows[0][0].ToString();
            //query que busca o vol Negocios
            string queryVol = "SELECT P.patrimonio_acossiativo_e_capital_social AS[VolumeNegocios]  FROM Parques_cientificos P WHERE P.id_parque = '" + id1 + "'";
            DataTable vol = ConecaoSQLServer.ExecutaSql(queryVol);
            string v = vol.Rows[0][0].ToString();
            //query que busca a area
            string queryArea = "SELECT N.nome_area FROM Areas_negocios A, Nome_area N WHERE N.id_nome_area = A.id_nome_area AND A.id_parque='" + id1 + "'";
            DataTable area = ConecaoSQLServer.ExecutaSql(queryArea);
            string[] a = new string[area.Rows.Count];
            for(int j = 0; j <= area.Rows.Count-1; j++)
            {
                a[j] = area.Rows[j][0].ToString();
            }
            //query que busca servicos e espaço
            string queryInc = "SELECT S.tipo_servico FROM Servicos_incubadora S, Incubadoras I WHERE I.id_incubadora = S.id_incubadora AND I.id_parque = '" + id1 + "'";
            DataTable inc = ConecaoSQLServer.ExecutaSql(queryInc); 
            string[] inc1 = new string[inc.Rows.Count];
            for (int j = 0; j <= inc.Rows.Count-1; j++)
            {
                    inc1[j] = inc.Rows[j][0].ToString();
            }
            string queryInc2 = "SELECT E.tipo_espaco FROM Espacos_incubadora E, Incubadoras I WHERE I.id_incubadora = E.id_incubadora AND I.id_parque = '" + id1 + "'";
            DataTable inc2 = ConecaoSQLServer.ExecutaSql(queryInc2);
            string[] inc22 = new string[inc2.Rows.Count];
            for (int j = 0; j <= inc2.Rows.Count - 1; j++)
            {
                inc22[j] = inc2.Rows[j][0].ToString();
            }
            //query que busca a designação
            string queryTi = "SELECT I.designaca FROM Instalacoes I WHERE I.id_parque = '" + id1 + "' ";
            DataTable ti = ConecaoSQLServer.ExecutaSql(queryTi);
            string[] tist = new string[ti.Rows.Count];
            for (int j = 0; j <= ti.Rows.Count-1; j++) {
                tist[j] = ti.Rows[j][0].ToString();
            }

            //Documento XML ********************************************************
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            //nome do parque
            XmlNode parqueNode = doc.CreateElement("parque");
            XmlAttribute pqAttribute = doc.CreateAttribute("nome");
            pqAttribute.Value = id.Rows[0][1].ToString();
            parqueNode.Attributes.Append(pqAttribute);
            doc.AppendChild(parqueNode);

            //morada
            XmlNode localNode = doc.CreateElement("Morada");
            localNode.AppendChild(doc.CreateTextNode(l));//
            parqueNode.AppendChild(localNode);

            //fase desenvolvimento
            XmlNode faseNode = doc.CreateElement("FaseDesenvolvimento");
            faseNode.AppendChild(doc.CreateTextNode(f));//
            parqueNode.AppendChild(faseNode);

            //volNegocios
            XmlNode volNode = doc.CreateElement("VolumeNegocios");
            volNode.AppendChild(doc.CreateTextNode(v));//
            parqueNode.AppendChild(volNode);

            //areas
            XmlNode areaN = doc.CreateElement("Areas");
            parqueNode.AppendChild(areaN);
            for (int j = 0; j <= area.Rows.Count-1; j++)
            {
                XmlNode areaNode = doc.CreateElement("AreaNegocio");
                areaNode.AppendChild(doc.CreateTextNode(a[j]));//
                areaN.AppendChild(areaNode);
            }

            //incubadoras
            XmlNode incN = doc.CreateElement("TipoDeServicos");
            parqueNode.AppendChild(incN);
            for (int j = 0; j <= inc.Rows.Count-1; j++)
            {
                XmlNode incNode = doc.CreateElement("Sercico");
                incNode.AppendChild(doc.CreateTextNode(inc1[j]));//
                incN.AppendChild(incNode);
            }
            XmlNode inc2N = doc.CreateElement("TiposDeEspaco");
            parqueNode.AppendChild(inc2N);
            for (int j = 0; j <= inc2.Rows.Count-1; j++)
            {
                XmlNode inc2Node = doc.CreateElement("Espaco");
                inc2Node.AppendChild(doc.CreateTextNode(inc22[j]));//
                inc2N.AppendChild(inc2Node);
            }

            //ti
            XmlNode tiN = doc.CreateElement("Instalacoes");
            parqueNode.AppendChild(tiN);
            for (int j = 0; j <= ti.Rows.Count-1; j++)
            {
                XmlNode instNode = doc.CreateElement("TipoDeInstalacao");
                instNode.AppendChild(doc.CreateTextNode(tist[j]));//
                tiN.AppendChild(instNode);
            }

            string nomeDoc = id.Rows[0][1].ToString().Replace(" ", "")+ "_XMLparque.xml";
            doc.Save(@"C:\Users\Asus\Source\Repos\sad\ITICH\ITICH\Xml\"+ nomeDoc);
            
            string root = @"C:\Users\Asus\Desktop\XMLparques";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
                doc.Save(@"\Users\Asus\Desktop\XMLparques\" + nomeDoc);//COLOCAR A DATA NO NOME
                SaveXml(nomeDoc);//Guarda na bd
            }
            else if(Directory.Exists(root))
            {
                doc.Save(@"\Users\Asus\Desktop\XMLparques\" + nomeDoc);
                SaveXml(nomeDoc);//Guarda na bd
            }

            return @"\Users\Asus\Desktop\XMLparques\" + nomeDoc;
        //C: \Users\Asus\Desktop >
        }
        public static void SaveXml(string xmlFileName)//metodo que guarda na base de dados o XML
        {
            //verifica qual é o utilizador que está logado
            int utilizadorLogadoId = Login.dadosLoginID;

            // read your XML
            string xmlContent = File.ReadAllText(@"C:\Users\Asus\Source\Repos\sad\ITICH\ITICH\Xml\" + xmlFileName);

            // set up query
            string insertQuery = "INSERT INTO Resultados_simulacao(id_empresa, resultado) VALUES ('"+utilizadorLogadoId+"', '"+xmlFileName+"')";
            ConecaoSQLServer.ExecutaSql(insertQuery);
        }
    }
}
