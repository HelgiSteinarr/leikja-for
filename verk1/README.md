## Verkefni 1

1. Gameloopan er aðalloopa sem allt annað keyrir innaní, hvort sem það eru aðrar loopur, föll eða annað. GameLoopan keyrir alltaf á sama hraða sama hvaða umhverfi og búnað hún er að keyra á og kallar alltaf á það sama í sömu röð aftur og aftur t.d. input frá notanda, uppfærir svo leikinn, renderar og svo keyrir aftur. Þetta dæmi var alveg basic en GameLoopur geta líka keyrt eins marga hluti og þú vilt hvert cycle/frame. t.d. Unity GameLoopan keyrir 32 föll/hluti hver cycle by default og auðvitað er hægt að bæta við það. 

2. Það væri hægt að útfæra það með að breyta hnitum hlutsins sem þú vilt hreyfa hvern frame eftir einhverju eins og input frá notanda eða annað. Allt í dag gerir það mikið flóknara og reiknar út hvernig hægt er að herma eftir raunverulegum kröftum sem eru að vinna á hlutnum.

3. Það gæti til dæmis verið gert með að athuga staðsetningu (hnit) hvers hluts í leiknum og ef einhver hlutur over lappar hnitin sem annar hlutur tekur up og það gerir eitthvað, hvort sem það er að láta annan hlutinn stoppa eða færa báða á útreiknuðum hraða út frá hraða hlutsins sem rakst í hinn. Unity gerir það nokkuð einfalt með innbyggðum föllum sem detecta collision sem þú getur bundið við einhvern hlut og unnið áfram með það t.d. gera mismunandi hluti eftir hvaða hlutur snerti hinn

---

Ef ætlar að prófa buildið þá mæli ég með að hafa hann í 720p(1280x720) og windowed þar sem ég hugsaði ekki útí hærri upplausnir og stærðir en "Game view" glugginn í editornum þegar ég bætti við post processing.

Annars er myndband hér af spilun [-->hér<--](https://vp.gudmunduro.com/?file=verkefni1_helgi.mp4)
