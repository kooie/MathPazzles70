CARD_COUNT = 100

def reverseCard(lst,startIdx,addV):
    while startIdx < CARD_COUNT:
        lst[startIdx] = not lst[startIdx]
        startIdx += addV

# 結果用リストresult
# 最初に100要素に対してFalse（裏向き状態）を設定
result = []
for i in range(CARD_COUNT):
    result.append(False)

# 現在のカードめくり開始位置
currentStartPosition = 1
# 現在のカードめくりの間隔
addNextIndex = 2

#reverseList(result,startPos,addValue)
while currentStartPosition < CARD_COUNT:
    # カードめくりはじめの位置
    # 一人目なら1,二人目なら2,....
    firstPos = currentStartPosition
    reverseCard(result,firstPos,addNextIndex)

    # N番目の人に交代する際には、自分のスタート位置 +1
    currentStartPosition = firstPos + 1 
    # N番目の人に交代する際には、自分のカードめくり間隔 +1
    addNextIndex += 1

# 結果を表示する
for i in range(len(result)):
    if result[i] == False:
        print('{0}'.format(i + 1))
