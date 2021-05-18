using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
namespace Test.Models
{
    public class CEP
    {
        public string BuscarCidade(Cidade cidade)
        {
            string strurlTest = string.Format("https://viacep.com.br/ws/{0}/json/",cidade.CEP);
            WebRequest requestObjGet = WebRequest.Create(strurlTest);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            string streesulttest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                streesulttest = sr.ReadToEnd();
                sr.Close();
            }
            return streesulttest;
            //WebRequest requestObjPost = WebRequest.Create(strurlTest);
            //requestObjPost.Method = "POST";
            //requestObjPost.ContentType = "application/json";
            //string postData = "{\"title\":\"testdata\",\"body\":\"testbody\",\"userId\":\"50\"}";
            //using (var streamWriter = new StreamWriter(requestObjPost.GetRequestStream()))
            //{
            //    streamWriter.Write(postData);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //    var httpResponse = (HttpWebResponse)requestObjPost.GetResponse();
            //    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //    {
            //        var result2 = streamReader.ReadToEnd();
            //    }
            //}
            //return "burro";
        }
    }
}