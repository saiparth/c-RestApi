using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Collections.Generic;
using System.Collections;
using Newtonsoft.Json;

namespace RestApiAutomation
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var client = new RestClient("https://jsonplaceholder.typicode.com/");

			var req = new RestRequest(Method.GET);

			req.Resource="posts/1";
			//req.AddParameter("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI1MDAwMDAwMDAwMDAxMzI5Iiwicm9sZSI6IjMiLCJGaXJzdE5hbWUiOiJ2Y2RhdXRvIiwiTGFzdE5hbWUiOiJCREQiLCJVc2VySUQiOiI1MDAwMDAwMDAwMDAxMzI5IiwiQ291cnNlSUQiOiIxMDA1MzE4MiIsIlRpbWVab25lSUQiOiI0OSIsIkFjbElEIjoiODAwMDAwMDAwMDAwNTM0MyIsIm5iZiI6MTUyNDA0MDgwOCwiZXhwIjoxNTI0MDUxOTA4LCJpYXQiOjE1MjQwNDA4MDgsImlzcyI6IlBlZ2FzdXMiLCJhdWQiOiJQZWdhc3VzTm90aWZpY2F0aW9ucyJ9.TmKCPrb2VJuNkRDb3tDmw2EfzY909wiY_txB_XdbCr8");
			//req.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI1MDAwMDAwMDAwMDAxMzI5Iiwicm9sZSI6IjMiLCJGaXJzdE5hbWUiOiJ2Y2RhdXRvIiwiTGFzdE5hbWUiOiJCREQiLCJVc2VySUQiOiI1MDAwMDAwMDAwMDAxMzI5IiwiQ291cnNlSUQiOiIxMDA1MzE4MiIsIlRpbWVab25lSUQiOiI0OSIsIkFjbElEIjoiODAwMDAwMDAwMDAwNTM0MyIsIm5iZiI6MTUyNDA0MDgwOCwiZXhwIjoxNTI0MDUxOTA4LCJpYXQiOjE1MjQwNDA4MDgsImlzcyI6IlBlZ2FzdXMiLCJhdWQiOiJQZWdhc3VzTm90aWZpY2F0aW9ucyJ9.TmKCPrb2VJuNkRDb3tDmw2EfzY909wiY_txB_XdbCr8");

			var res = client.Execute(req);

			var content = res.Content;
			  Dictionary<string,string> holder=JsonConvert.DeserializeObject<Dictionary < string,string>> (content);

		}
		
			[TestMethod]
		public void TestMethod2()
		{
			var client = new RestClient("http://api.football-data.org/");

			var req = new RestRequest(Method.GET);

			req.Resource = "v1/competitions/?season=2015";
			//req.AddParameter("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI1MDAwMDAwMDAwMDAxMzI5Iiwicm9sZSI6IjMiLCJGaXJzdE5hbWUiOiJ2Y2RhdXRvIiwiTGFzdE5hbWUiOiJCREQiLCJVc2VySUQiOiI1MDAwMDAwMDAwMDAxMzI5IiwiQ291cnNlSUQiOiIxMDA1MzE4MiIsIlRpbWVab25lSUQiOiI0OSIsIkFjbElEIjoiODAwMDAwMDAwMDAwNTM0MyIsIm5iZiI6MTUyNDA0MDgwOCwiZXhwIjoxNTI0MDUxOTA4LCJpYXQiOjE1MjQwNDA4MDgsImlzcyI6IlBlZ2FzdXMiLCJhdWQiOiJQZWdhc3VzTm90aWZpY2F0aW9ucyJ9.TmKCPrb2VJuNkRDb3tDmw2EfzY909wiY_txB_XdbCr8");
			//req.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI1MDAwMDAwMDAwMDAxMzI5Iiwicm9sZSI6IjMiLCJGaXJzdE5hbWUiOiJ2Y2RhdXRvIiwiTGFzdE5hbWUiOiJCREQiLCJVc2VySUQiOiI1MDAwMDAwMDAwMDAxMzI5IiwiQ291cnNlSUQiOiIxMDA1MzE4MiIsIlRpbWVab25lSUQiOiI0OSIsIkFjbElEIjoiODAwMDAwMDAwMDAwNTM0MyIsIm5iZiI6MTUyNDA0MDgwOCwiZXhwIjoxNTI0MDUxOTA4LCJpYXQiOjE1MjQwNDA4MDgsImlzcyI6IlBlZ2FzdXMiLCJhdWQiOiJQZWdhc3VzTm90aWZpY2F0aW9ucyJ9.TmKCPrb2VJuNkRDb3tDmw2EfzY909wiY_txB_XdbCr8");

			var res = client.Execute(req);

			var content = res.Content;
			List<Dictionary<string, string>> holder = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(content);

		}
	}
}
