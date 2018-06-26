---
--- Created by ju.
--- DateTime: 2017/10/23 14:45
--- 小结算
---@class SingleResultModule
---@field view SingleResultView
local ModuleBase = require("core.mvvm.module_base")
local Class = require("lib.middleclass")

local Manager = require("package.public.module.function_manager")
local TableUtilPaoHuZi = require("package.huapai.module.tablebase.table_util")
local SoundManager = require("package.huapai.module.table.sound_manager")
local ModuleCache = ModuleCache

local SingleResultModule = Class("SingleResult", ModuleBase)
local coroutine = require("coroutine")
local curTableData


function SingleResultModule:initialize(...)
    
    curTableData = TableManager.phzTableData
    ModuleBase.initialize(self, "singleresult_view", nil, ...)
end

--- 设置标题
--- @param value number 1-自己赢，2-下家赢，3-上家赢
function SingleResultModule:set_title(value)

  

    self.view.R1.gameObject:SetActive(false)
    self.view.R2.gameObject:SetActive(false)
    self.view.R3.gameObject:SetActive(false)
    if value == 1 then
        self.view.R2.gameObject:SetActive(true)

    end

    if value == 2 or value == 3 then
        self.view.R3.gameObject:SetActive(true)
    end

    if value == 0 then

        SoundManager:play_nameroot("黄庄")
        self.view.R1.gameObject:SetActive(true)
    end

    
end

--- 设置底牌
function SingleResultModule:set_dipai(data, mapai)
    mapai = mapai or {}
    print("剩余牌数", #data)
    Manager.DestroyChildren(self.view.dipaiParent, self.view.dipaiSample)
   
    
    for i = 1, #data do
        if data[i] >= 0 and data[i] < 25 then
            TableUtilPaoHuZi.print("-----", data[i])
            local obj = Manager.CopyObject(self.view.dipaiSample)
            local text = Manager.GetText(obj, "Score")
            text.text = ""
            print(data[i])
            TableUtilPaoHuZi.set_card(obj, data[i], nil, 'ZiPai_PlayCards')
            Manager.SetActive(obj, true)
        end
    end
end




--- 设置胡牌下张
--- @param data
--- @param pai number 胡的牌
function SingleResultModule:set_xiazhang(data, pai)
    if 1 == 1  then
        return
    end

    Manager.DestroyChildren(self.view.xiazhangParent, self.view.xiazhangSample)
    for i = 1, #data do
        local obj = Manager.CopyObject(self.view.xiazhangSample)
        local name = Manager.GetText(obj, "Name")
        local huxi = Manager.GetText(obj, "Huxi")
        name.text = data[i].des
        huxi.text = tostring(data[i].hu_shu)

        if AppData.Game_Name == "GLZP" then
            name.gameObject:SetActive(false)
        end

        local findTag = false
        for j = 1, 4 do
            local cardObj = Manager.FindObject(obj, "Cards/" .. tostring(j))
            if data[i].pai[j] then
                local value = data[i].pai[j]
                TableUtilPaoHuZi.set_card(cardObj, value.pai, nil, 'ZiPai_PlayCards')
                Manager.SetActive(cardObj, true)
                local tag = Manager.FindObject(cardObj, "Image/Hu")
                --- 约定胡的牌始终在最后一列
                if i == #data and not findTag and data[i].pai[j] == pai then
                    findTag = true
                    Manager.SetActive(tag, true)
                end
            else
                Manager.SetActive(cardObj, false)
            end
        end
        Manager.SetActive(obj, true)
    end
end

--- 设置放炮位置
--- @param value number 1-自己放炮，2-下家放炮，3-上家放炮，4-自摸
function SingleResultModule:set_pao(value)
    if 1 == 1  then
        return
    end
    self.view.paoImg.sprite = self.view.paoSpriteHolder:FindSpriteByName(tostring(value))
    self.view.paoImg:SetNativeSize()
end

--- 设置胡法
function SingleResultModule:set_hufa(data, huxi)
    if 1 == 1  then
        return
    end
    local str = ""
    Manager.DestroyChildren(self.view.suanfenParent, self.view.suanfenSample)
    Manager.DestroyChildren(self.view.suanfenParent1, self.view.suanfenSample1)
    

    for i = #data, 1,-1 do

        if data[i].display_position == 1 then
            str = str .. data[i].name .. "  "
        end

        if data[i].display_position == 2 then
            local obj = Manager.CopyObject(self.view.suanfenSample)
            local name = Manager.GetText(obj, "Name")
            local score = Manager.GetComponentWithPath(obj, "Score", "TextWrap")
            name.text = data[i].name
            score.text = tostring(data[i].fen)
            if not data[i].is_addition then
                score.text = "*" .. tostring(data[i].fen)
            end
            Manager.SetActive(obj, true)

            print(tostring(data[i].fen),score.text)
        end

        

        if data[i].display_position == 3 then
            local obj = Manager.CopyObject(self.view.suanfenSample1)
            local name = Manager.GetText(obj, "Name")
            local score = Manager.GetComponentWithPath(obj, "Score", "TextWrap")
            name.text = data[i].name
            score.text = tostring(data[i].fen)
            if not data[i].is_addition then
                score.text = "*" .. tostring(data[i].fen)
            end
            Manager.SetActive(obj, true)
            
        end

    end

 

    self.view.hufa.text = str
    TableUtilPaoHuZi.print("胡法", str)
end

--- 设置输赢
--- @param score number 输赢多少分
function SingleResultModule:set_win(score)
    if 1 == 1  then
        return
    end
    if score == nil then
        self.view.winImg.gameObject:SetActive(false)
        return
    else
        self.view.winImg.gameObject:SetActive(true)
    end

    local str = tostring(score)
    if score > 0 then
        str = "+" .. score
    end
    self.view.winScoreRed.text = str
    self.view.winScoreGreen.text = str
    Manager.SetActive(self.view.winScoreRed.gameObject, score > 0)
    Manager.SetActive(self.view.winScoreGreen.gameObject, score <= 0)
    self.view.winImg.sprite = self.view.winSpriteHolder:FindSpriteByName(tostring(score > 0 and 1 or 2))
--self.view.winScore.text = tostring(score)
end

--- 设置将牌
--- @param value number
function SingleResultModule:set_jiang(value)
    --self.view.jiang.gameObject:SetActive(false)
end

function SingleResultModule:on_show(intentData)
    
    self:start_lua_coroutine(function()
        --self.view.root.gameObject:SetActive(true)
       
     
        self.view.WanFaShow.text = self:getstrByWanFa()

        self:start_lua_coroutine(function ()
            self:InitPersonInfos(intentData)
        end)
        

        Manager.SetActive(self.view.btnNext.gameObject, not curTableData.isPlayBack and DataHuaPai.Msg_Table_GameStateNTFNew.result == 1)
        if self.view.btnExit then
            Manager.SetActive(self.view.btnExit.gameObject, not curTableData.isPlayBack and DataHuaPai.Msg_Table_GameStateNTFNew.result == 2)
        end
        Manager.SetActive(self.view.btnTotal.gameObject, not curTableData.isPlayBack and DataHuaPai.Msg_Table_GameStateNTFNew.result == 2)
        Manager.SetActive(self.view.btnBack.gameObject, curTableData.isPlayBack)
        Manager.SetActive(self.view.btnShow.gameObject, true)
        local winSeat = 0
        local paoSeat = 1
        local localSeatID_i = 0
        for i = 1, #intentData.player do
            local localSeatID = TableUtilPaoHuZi.get_local_seat(i - 1, curTableData.SeatID, 3)
            if localSeatID == 1 then
                localSeatID_i = i
            end
            if intentData.player[i].hu_pai > 0 then
                TableUtilPaoHuZi.print("赢家", localSeatID)
                winSeat = localSeatID
                self:set_xiazhang(intentData.player[i].xia_zhang, intentData.player[i].hu_pai)
                self:set_hufa(intentData.player[i].HuFa, intentData.player[i].round_hu_xi)
                --self.view.ZongScore.text = intentData.player[i].round_hu_xi
                self:set_dipai(intentData.dun)
                --self.view.ZongScoreT.text = intentData.player[i].round_hu_xi
            end
            if i - 1 == intentData.loser then
                paoSeat = localSeatID
            end
            if localSeatID == 1 then
                self:set_win(intentData.player[i].round_score)
            end
        end
        self:set_title(winSeat)
        if winSeat == 0 then
            --self:show_huangzhuang()
            
        else
            --- 自摸特殊处理
            if intentData.loser == 4294967295 then
                paoSeat = 4
            end
            TableUtilPaoHuZi.print("放炮Index", paoSeat, intentData.loser)
            self:set_pao(paoSeat)
            self:set_jiang(intentData.jiang_pai)
        end

        local ruleInfo = TableUtilPaoHuZi.convert_rule(TableManager.phzTableData.Rule)
        if ruleInfo.baseScore then
            
        else
            if DataHuaPai.Msg_Table_GameStateNTF.CurRound % curTableData.RoundCount == 0 then
                return
            end
        end
        if curTableData.isPlayBack then
            return
        end
        self:DaoJiShiAnNiu()

        self:DaoJiShi()


    end)
end

function SingleResultModule:DaoJiShiAnNiu()
    if not self.view.btnNextText then
        return
    end
    self.view.btnNextText.text = ""

    for i=1,20 do
        coroutine.wait(0.1)
        if not self.view then
            return
        end
         
        local num = 0

        if DataHuaPai.Msg_Table_UserStateNTF_Self then
            num = DataHuaPai.Msg_Table_UserStateNTF_Self.RestTime
        end

        print(num)
        if num > 1 then
            break
        end
        if i == 20 then
            return
        end
    end

    
    for i=DataHuaPai.Msg_Table_UserStateNTF_Self.RestTime,1,-1 do
        
        self.view.btnNextText.text = tostring(i)
        coroutine.wait(1)
        if not self.view then
            return
        end
    end
    self.view.btnNextText.text = ""
    if self.view then
        --self:dispatch_module_event("roomsetting", "Event_RoomSetting_ExitRoom")
    end

end

function SingleResultModule:DaoJiShi()
    if AppData.Game_Name == "GLZP" then
        for i=5,1,-1 do
            self.view.TextDaoJiShi.text = '倒计时' .. i .. '秒'
            coroutine.wait(1)
            if not self.view then
                return
            end
        end
        self.view.TextDaoJiShi.text = ''
        self:dispatch_module_event("tablestrategy", "Event_Show_TableStrategy")
        ModuleCache.ModuleManager.destroy_module("huapai", "singleresult")
    end
end


--- 显示桌面/返回结算
function SingleResultModule:show_table(show)
    Manager.SetActive(self.view.bg, not show)
    Manager.SetActive(self.view.titleImg.gameObject, not show)
    Manager.SetActive(self.view.leftObj, not show)
    Manager.SetActive(self.view.rightObj, not show)
    Manager.SetActive(self.view.btnShow.gameObject, not show)
    Manager.SetActive(self.view.btnHide.gameObject, show)
   
  
end

--- 显示黄庄
function SingleResultModule:show_huangzhuang()
    Manager.SetActive(self.view.bg, false)
    Manager.SetActive(self.view.titleImg.gameObject, false)
    Manager.SetActive(self.view.leftObj, false)
    Manager.SetActive(self.view.rightObj, false)
    Manager.SetActive(self.view.btnShow.gameObject, false)
    Manager.SetActive(self.view.btnHide.gameObject, false)
    Manager.SetActive(self.view.huangzhuang, true)

end




function SingleResultModule:on_click(obj, arg)
    ModuleCache.SoundManager.play_sound("henanmj", "henanmj/sound/button.bytes", "button")
    if obj == self.view.btnShow.gameObject then
        
        ModuleCache.ShareManager().shareImage(false)

    elseif obj == self.view.btnHide.gameObject then
        self:show_table(false)
    elseif obj == self.view.btnHide.gameObject then
        self:show_table(false)
    elseif obj == self.view.btnExit.gameObject then
        self:dispatch_module_event("roomsetting", "Event_RoomSetting_ExitRoom")
    elseif obj == self.view.btnNext.gameObject then
        local ruleInfo = TableUtilPaoHuZi.convert_rule(TableManager.phzTableData.Rule)

        if not ruleInfo.baseScore or DataHuaPai.Msg_Table_UserStateNTF_Self.Balance > ruleInfo.baseScore * 25 then
            self:dispatch_module_event("tablestrategy", "Event_Show_TableStrategy")
            ModuleCache.ModuleManager.destroy_module("huapai", "singleresult")
        else
            self:dispatch_module_event("tablestrategy", "Event_Show_TableStrategy")
            self:start_lua_coroutine(function ()
                DataHuaPai.Msg_Table_UserStateNTF_Self = nil
    
                while DataHuaPai.Msg_Table_UserStateNTF_Self == nil do  
                    coroutine.wait(0.1)
                    if not self.view then
                        return
                    end
                end
                if tonumber(DataHuaPai.Msg_Table_UserStateNTF_Self.ErrCode) == -888 then

                    ModuleCache.ModuleManager.show_public_module("alertdialog"):show_other_confirm_cancel("您的金币不足，  是否立即补充金币继续游戏？ ", function()
                        
                        ModuleCache.ModuleManager.show_module("public", "goldadd")
                    end, nil, true, "确 认", "取 消")  
                else
                    ModuleCache.ModuleManager.destroy_module("huapai", "singleresult")
                end
            end)
        end

    elseif obj == self.view.btnTotal.gameObject then
        ModuleCache.ModuleManager.destroy_module("huapai", "singleresult")
        ModuleCache.ModuleManager.get_module("huapai", "totalresult"):show_result()
    elseif obj == self.view.btnBack.gameObject then
        ModuleCache.ModuleManager.destroy_module("huapai", "singleresult")
        ModuleCache.ModuleManager.destroy_module("huapai", "table")
        ModuleCache.ModuleManager.show_module("henanmj", "hall")
    end
end

function SingleResultModule:set_room_info(round, startTime, endTime)
	--self.TextRoomNum = Manager.GetText(self.root, "Bg/Title1/TextRoomNum")
	--self.TextPlayInfo = Manager.GetText(self.root, "Bg/Title1/TextPlayInfo")
	--self.TextRoundNum = Manager.GetText(self.root, "Bg/Title1/TextRoundNum")

	--self.TextPlayInfoPai = Manager.GetText(self.root, "Bg/Title1/TextPlayInfoPai")
	--self.StartTime = Manager.GetText(self.root, "Bg/Title1/StartTime")

	--self.EndTime = Manager.GetText(self.root, "Bg/Title1/EndTime")


    local ruleInfo1,
        ruleInfo2,
        ruleInfo3,
        ruleInfo4 = TableUtilPaoHuZi.get_rule_name(curTableData.Rule, curTableData.HallID == 0)
    self.view.TextRoomNum.text = "房号:" .. curTableData.RoomID
  
    
    self.view.TextRoundNum.text = string.format("第%d/%d局", round, curTableData.RoundCount)


    
    self.view.TextPlayInfo.text = "恩施绍胡"
    


    if os.date("%Y/%m/%d %H:%M", startTime - 2208988800 - 3600 * 8) ~= nil then
        print("时间哦               ", startTime, endTime)
        self.view.StartTime.text = "" .. os.date("%Y/%m/%d %H:%M", startTime - 2208988800 - 3600 * 8)
    end

    if endTime then
        self.view.EndTime.text = "" .. os.date("%Y/%m/%d %H:%M", endTime - 2208988800 - 3600 * 8)
        
    end
end

function SingleResultModule:InitPersonInfosPai(data)

    --         coroutine.wait(0.02)
    --self.view.personInfos[i].XiaZhangHolderGrid.enabled = false
    for i = 1, #data.player do
        self.view.personInfos[i].XiaZhangHolderGrid.enabled = true
    end
    coroutine.wait(0.02)
    for i = 1, #data.player do
        self.view.personInfos[i].XiaZhangHolderGrid.enabled = false
    end

    for i = 1, #data.player do
        local xiaData = data.player[i].xia_zhang
        --repeated HP_PAI pai		= 1;
        --optional int32 hu_shu	= 2;
       -- optional string des		= 3;//描述
        --optional bool is_kua_kan =4;//是否为挎坎
        for j=1,10 do
            self.view.personInfos[i].XiaZhang[j].go.gameObject:SetActive(false)
        end
    
        for j=1,#xiaData do

            if self.view.personInfos[i].XiaZhang[j] then
            self.view.personInfos[i].XiaZhang[j].Name.text = xiaData[j].des
            self.view.personInfos[i].XiaZhang[j].FenShu.text = xiaData[j].hu_shu
            if xiaData[j].des == "" then
                self.view.personInfos[i].XiaZhang[j].FenShu.text = ""
            end
            self.view.personInfos[i].XiaZhang[j].go.gameObject:SetActive(true)

            for k=1,8 do
                local go = self.view.personInfos[i].XiaZhang[j].paimen[k]
                go:SetActive(true)
            end

            for k=1,8 do
                local go = self.view.personInfos[i].XiaZhang[j].paimen[k]
                go.transform:SetSiblingIndex(8 - k)
            end

            for k=1,8 do
                local go = self.view.personInfos[i].XiaZhang[j].paimen[k]

                local count = #xiaData[j].pai
                if count > 3 then
                    if xiaData[j].pai[k] then
                        TableUtilPaoHuZi.set_card(go, xiaData[j].pai[count + 1 - k].pai, nil, 'ZiPai_PlayCards')
                    else
                        go:SetActive(false)
                    end

                else
                    if xiaData[j].pai[k] then
                        TableUtilPaoHuZi.set_card(go, xiaData[j].pai[k].pai, nil, 'ZiPai_PlayCards')
                    else
                        go:SetActive(false)
                    end

                end
            end
            end



        end

        for j=1,#xiaData do
            if #xiaData[j].pai > 3 then
                -- 所有后面的全部 移动位置
                for y=j+1,#xiaData do
                    local trans = self.view.personInfos[i].XiaZhang[y].go.transform
                    local pos = trans.localPosition
                    pos.x = pos.x + 30
                    trans.localPosition = pos
                end
            end
        end

    end
end

function SingleResultModule:InitPersonInfos(data)
    self:start_lua_coroutine(function ()
        self:InitPersonInfosPai(data)
    end)
    

    self:set_room_info(data.CurRound, data.starttime, data.endtime)
    local datam = DataHuaPai.Msg_Table_GameStateNTF
    local ScoreSettle = datam.ScoreSettle
    local ScoreSettleta = {}
    for i,v in ipairs(ScoreSettle) do
        ScoreSettleta[v.SeatID] = v.ActualAmount
    end

    for i = 1, 3 do
        self.view.personInfos[i].Go:SetActive(false)
    end
    
    for i = 1, #data.player do
        self.view.personInfos[i].Go:SetActive(true)
        local round_score = tostring(ScoreSettleta[i - 1])
        --XiaZhangHolder

        if tonumber(round_score) == nil then
            round_score = data.player[i].round_score
        end
    
        if tonumber(round_score) == nil then
            round_score = 0
        end

        if tonumber(round_score) > 0 then
            self.view.personInfos[i].XiaZhangHolder.gameObject:SetActive(true)
        else
            --self.view.personInfos[i].XiaZhangHolder.gameObject:SetActive(false)
        end

        local dataD = data.player[i]


        local fangzhu = self.view.personInfos[i].Fang

      
        Manager.SetActive(fangzhu, curTableData.FangZhu == i - 1)

        local zhuang = self.view.personInfos[i].Zhuang
        Manager.SetActive(zhuang, data.zhuang == i - 1)


 
        if TableManager.phzTableData.seatUserIdInfo ~= nil then
            TableUtilPaoHuZi.download_seat_detail_info(TableManager.phzTableData.seatUserIdInfo[tostring(i - 1)],
                function(playerInfo)
                    if not self.view then
                        return
                    end
                    self.view.personInfos[i].Image.sprite = playerInfo.headImage
                    self.view.personInfos[i].Name.text =  Util.filterPlayerName(playerInfo.playerName, 10)
                end)
            self.view.personInfos[i].ScoreWin.text =  "" .. round_score
			self.view.personInfos[i].ScoreLose.text = round_score
			self.view.personInfos[i].ScoreWin.gameObject:SetActive(false)
            self.view.personInfos[i].ScoreLose.gameObject:SetActive(false)
            

            local qiangShu = 0
            for k=1,#dataD.HuFa do
                local name = dataD.HuFa[k].name
                if (string.find(name, '枪') ~= nil) or (string.find(name, '八可') ~= nil) then
                    qiangShu = qiangShu + dataD.HuFa[k].fen
                end
            end

            if tonumber(round_score) > 0 then
                
                self.view.personInfos[i].ScoreWin.gameObject:SetActive(true)
                

               
            else
				
                self.view.personInfos[i].ScoreLose.gameObject:SetActive(true)

            end

            self.view.personInfos[i].HuShu.text = ""
            self.view.personInfos[i].QiangShu.text = ""

            self.view.personInfos[i].HuImg.gameObject:SetActive(false)
            for k,v in pairs(self.view.personInfos[i].HuTable) do
                v.gameObject:SetActive(false)
            end
            for j=1,#dataD.HuFa do
                local name = dataD.HuFa[j].name
                for k,v in pairs(self.view.personInfos[i].HuTable) do
                    if name == k then
                        self.view.personInfos[i].HuImg.gameObject:SetActive(true)
                        v.gameObject:SetActive(true)
                        self.view.personInfos[i].HuShu.text = '胡数:' ..  dataD.round_hu_shu
                        self.view.personInfos[i].QiangShu.text ='枪数:' ..  qiangShu
                        break
                    end
                end
            end
            self.view.personInfos[i].Hu.gameObject:SetActive(true)
        else
            TableUtilPaoHuZi.download_seat_detail_info(TableManager.phzTableData.players[i].userId,
                function(playerInfo)
                    self.view.personInfos[i].Image.sprite = playerInfo.headImage
                    self.view.personInfos[i].Name.text = playerInfo.playerName
                end)
            self.view.personInfos[i].ScoreWin.text = "" .. round_score
			self.view.personInfos[i].ScoreLose.text = round_score
			self.view.personInfos[i].ScoreWin.gameObject:SetActive(false)
            self.view.personInfos[i].ScoreLose.gameObject:SetActive(false)
            
            
            if tonumber(round_score) > 0 then
			
                self.view.personInfos[i].ScoreWin.gameObject:SetActive(true)
                self.view.personInfos[i].HuShu.text = '胡数:' ..  dataD.round_hu_shu
                self.view.personInfos[i].QiangShu.text ='枪数:' ..  "0"
            else
			
                self.view.personInfos[i].ScoreLose.gameObject:SetActive(true)
                self.view.personInfos[i].HuShu.text = ""
                self.view.personInfos[i].QiangShu.text = ""
            end
        end
    end
end

function SingleResultModule:getstrByWanFa()
    local ruleInfo = TableUtilPaoHuZi.convert_rule(curTableData.Rule)
    
    if AppData.Game_Name == "LDZP" then
        local str = ""..ruleInfo.roundCount.."胡息结算   "


        if ruleInfo.FengDing then
            str = str .. ' 封顶' .. ruleInfo.FengDing .. '胡息   '
        end

        if ruleInfo.DaTuo == 0 then
            str = str .. '不打坨   '
        elseif ruleInfo.DaTuo == 1 then
            str = str .. '打坨   '
        end

        if ruleInfo.JiePaoFengDing == 0 and AppData.Game_Name == "LDZP" then
            str = str .. '接炮不封顶   '
        elseif ruleInfo.JiePaoFengDing == 100 and AppData.Game_Name == "LDZP" then
            str = str .. '接炮100封顶   '
        end

        if ruleInfo.DiFen then
            str = str .. '底分' .. ruleInfo.DiFen/1000 .. '   '
        end

        if ruleInfo.SeatRule == 1 then
            str = str .. '不换位   '
        elseif ruleInfo.SeatRule == 2 then
            str = str .. '每局换位   '
        end

            
        if ruleInfo.PayType ~= nil then
            if ruleInfo.PayType == 0 then
                str =str ..  '房主支付 '
            end
    
            if ruleInfo.PayType == 1 then
                str =str ..  'AA支付 '
            end
    
            if ruleInfo.PayType == 2 then
                str =str ..  '大赢家支付 '
            end
        end
    
        return str
    end




    if ruleInfo == nil or ruleInfo.HuPaiRule == nil then
        return ""
    end
    local str = ""
    str = str ..ruleInfo.HuPaiRule .. '胡起胡   '
    str = str ..ruleInfo.SettleRule ..  '胡1子   '
  
    if ruleInfo.ZiMoRule == 1 then
        str = str .. '自摸加1   '
    elseif ruleInfo.ZiMoRule == 2 then
        str = str .. '自摸翻倍   '
    end

    if ruleInfo.SeatRule == 1 then
        str = str .. '不换位   '
    elseif ruleInfo.SeatRule == 2 then
        str = str .. '每局换位   '
    end
    
    if ruleInfo.DiaoPaoRule == true then
        str = str .. '可点炮   '
    else
        str = str .. '不可点炮   '
    end
    
    if ruleInfo.ShangXingRule == true then
        str = str .. '上醒   '
    end
    
    if ruleInfo.BenXingRule == true then
        str = str .. '本醒   '
    end
    
    if ruleInfo.XiaXingRule == true then
        str = str .. '下醒   '
    end
    return str
end

function SingleResultModule:on_destroy()
    ModuleCache.SoundManager.audioMusic.mute = false
end

return SingleResultModule