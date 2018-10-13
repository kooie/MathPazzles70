# Pull Requestまでの流れ

## Flow
1. タスク、問題を起票する。[Issue](#issue)
1. 作業開始の準備をする。 [Fork ~ Checkout](#fork--checkout)  
1. 作業(機能追加や修正等)する。 [Commit ~ Push](#commit--push)  
1. 作業が完了するまで2を繰り返す。
1. 作業を完了する。 [PullRequest](#pullrequest)

## Issue
1. Issueを作成する。
タスク、バグなのかを明記する。

## Fork ~ Checkout
1. 右上の[Fork]を押下して、個人アカウント下にリモートリポジトリをCloneを追加する。
2. クローンした個人のリモートリポジトリのトップで[Clone or download]を押下し、文字列をコピーする。  
コピーする文字列は HTTPSとSSHの2種類あるため、個人の環境に合わせたものを使用する。
3. コマンドプロンプトで任意のワークスペースに移動し、下記コマンドを実行する。  
```
git clone コピーした文字列
```
4. 下記コマンドでローカルリポジトリ下に移動後に、`develop`を元に新しいブランチを作る。  
新しいブランチ名は説明的な名前を付けたブランチにする方が良い。
```
cd MathPazzles70
git checkout -b 新しいブランチ名 develop
```

## Commit ~ Push
1. Commitする。できるだけまとまった単位かつ、分かりやすいコメントでCommitするのが良い。  
(新規ファイルがある場合は`git add`で対応する必要がある。)
```
git commit -am 'コメント'
```
1. Pushする。ブランチ名は基本的に作業開始時に作成したブランチ名で良い。
```
git push origin ブランチ名
```

## PullRequest
1. 個人のローカルリポジトリのTopの右上の[Compare & pull request]を押下し、PullRequestを行う。  
PullRequestの向き先は`develop`にする。  
コメントに#Issue番号 をつけると自動的に紐づけられるため、つける方が良い。  
`Fix #Issue番号` や `Resolve #Issue番号` と書くと、PullRequestがマージされた際に、完了扱いとなり閉じられる。
2. レビューがNGだった場合は、再度修正する。

## 作成にあたって参考にした記事  
[git flowとgithub flowとは？その違いは？](https://qiita.com/mint__/items/bfc58589b5b1e0a1856a)  
[Github で Fork してから Pull Request をするまでの流れ](http://kik.xii.jp/archives/179)  
[コミット時にIssueをCloseする](https://qiita.com/maeda_t/items/d9ef98bf651bd491b16d)
