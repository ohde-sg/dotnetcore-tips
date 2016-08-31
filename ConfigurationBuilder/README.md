# ConfigurationBuilderがカッコイイのでメモ

* ## vscodeを使っている場合
launch.jsonのargsにファイルパス(config.json,config.xmlのパス)を書いておけば実行時に引数として扱ってくれる
```
    "configurations": [
        {
            "args": "path to importfiles(config.json, config.xml)"
```

* ## コマンドラインから実行
```
$ dotnet restore
$ dotnet run ./
```

* ## 実行結果
ConfigurationBuilderでAddした複数の形式のファイルに記載された変数と環境変数を参照できる。
```
Project ConfigurationBuilder (.NETCoreApp,Version=v1.0) will be compiled because inputs were modified
Compiling ConfigurationBuilder for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:02.0124741
 

config["HOME"] = "path to your home dir"
config["Settings:Name_XML"] = xml setting file
config["NAME_JSON"] = json setting file
```