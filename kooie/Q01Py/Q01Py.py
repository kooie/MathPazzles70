# 回文判定
def isKaibun(str):
    return str == str[::-1]

loopFlg = True
i = 10

while (loopFlg):
    if (isKaibun(format(i,"d")) and isKaibun(format(i,"o")) and isKaibun(format(i,"b"))):
        loopFlg = False
        print(i)

    i += 1
