using System;
using Microsoft.Extensions.Configuration;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try{
                var builder = new ConfigurationBuilder()
                    .SetBasePath(args[0])       //設定ファイルを読み込むパス
                    .AddXmlFile("config.xml")   //xmlファイルを追加
                    .AddJsonFile("config.json") //jsonファイルを追加
                    .AddEnvironmentVariables(); //環境変数を追加
                var config = builder.Build();
                Console.WriteLine($"config[\"HOME\"] = {config["HOME"]}");                              //環境変数の設定値
                Console.WriteLine($"config[\"Settings:Name_XML\"] = {config["Settings:Name_XML"]}");    //xmlファイルの設定値
                Console.WriteLine($"config[\"NAME_JSON\"] = {config["NAME_JSON"]}");                    //jsonファイルの設定値
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
