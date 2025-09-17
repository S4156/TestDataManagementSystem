# Test Data Management System

製造業の現場を想定した検査データ管理ソフトです。
SQLiteを利用し、検査結果を保存・検索・グラフ表示できるようにしました。
<br><br>
## ■ 使用技術
- 言語: VB.NET (.NET 8)
- データベース: SQLite
- グラフ描画: ScottPlot
<br><br>
## ■ 主な機能
- データの登録・更新・削除
- DataGridView を使った一覧表示
- 合格率の推移を折れ線グラフで可視化

<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>

## ■ 画面サンプル
### データ登録画面
<img width="505" height="482" alt="Image" src="https://github.com/user-attachments/assets/fa438485-e5c0-4082-b6d6-59773b165607" />

### データ一覧画面（グラフ表示）
<img width="800" height="683" alt="Image" src="https://github.com/user-attachments/assets/d90d1afa-2de5-4fe9-a20f-9ff40432c062" />

## ■ 工夫した点
- UIとDBアクセスのコードを分離し、拡張性を高めた。
- SQLiteを利用し、軽量かつ簡単に扱えるデータベースを構築。
- ScottPlotでグラフを描画し、数値の推移を直感的に把握可能にした。

## ■ 今後の展望
- 検査結果をCSVファイルに出力する機能の追加
- 製品番号ごとの合格率表示機能の追加
