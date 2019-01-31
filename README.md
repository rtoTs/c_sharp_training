# c_sharp_training

macでc#を練習するための設定

** C#のコンパイラ(Mono)をインストール

MonoとはEcma標準に準じた.NET Framework互換の環境を実現するためのオープンソースのソフトウェア、C#のコンパイラが含まれています。インストールから実行例までを示します。

** home brewでMonoをインストール
<pre>
brew install mono
</pre>

** コンパイル
<pre>
mcs test.cs
</pre>

** 実行
<pre>
mono test.exe
</pre>

** 複数ファイルのコンパイル
<pre>
mcs test1.cs test2.cs -out:test.exe
$ mcs *.cs -out:test.exe
</pre>


# 備忘録

null合体演算子
<pre>
string nonNullStr = str ?? "default string";
</pre>

ショートサーキット評価
先に条件評価をして、それ以降評価する必要がないような場合（&&）とか