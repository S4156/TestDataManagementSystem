# ■ Test Management App

製造業の現場を想定した検査データ管理ソフトです。
SQLiteを利用し、テスト結果を保存・検索・グラフ表示できるようにしました。

## ■ 使用技術
- 言語: VB.NET (.NET 8)
- DB: SQLite
- グラフ: ScottPlot

## ■ 主な機能
- テスト結果の登録・検索
- DataGridView を使った一覧表示
- 合格率の推移を折れ線グラフで可視化
- 日付範囲を指定した集計表示

## ■ 画面サンプル
### 一覧画面
![list](docs/list.png)

### 合格率の推移（グラフ表示）
![chart](docs/chart.png)

## ■ 工夫した点
- Repositoryパターンを採用し、UIとDBアクセスを分離
- SQLiteを利用し、軽量かつ簡単に扱えるデータベースを構築
- ScottPlotでグラフを描画し、数値の推移を直感的に把握できるようにした
