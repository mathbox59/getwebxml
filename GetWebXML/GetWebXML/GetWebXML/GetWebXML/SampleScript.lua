
--allviewsToLua
function  allviewsToLua(controlList) 
    --数组，用于保存页面所有控件对象
    controlListFromOC = controlList["controlList"]
end


-- 隐藏控件
function hideControl(pageDict)
    local page = pageDict["page"]
    local hideControlList = {"BasicChart375232","BasicChart702861","BasicChart428299","BasicChart405406","BasicChart325779","BasicChart672933","BasicChart660499"}
    --local hideControlList = {"BasicChart702861"}
   --local hideControlList = {"BasicChart42471"}
    page:hideControls(hideControlList)
end

-- 控件事件注册
function eventRegister()
    animation = Animations:init()
    --local controIdAndEvents = {DataGrid904228="pinch"}
    local controIdAndEvents = {BasicChart86815="singleTap",Label264651="singleTap",Label722286="singleTap",Label263379="singleTap",Label520546="singleTap", DataGrid224761="pinch", BasicChart223325="pinch", BasicChart383147="singleTap", BasicChart660499 = "singleTap"}
    --local controIdAndEvents = {BasicChart86815="singleTap", DataGrid224761="pinch"}
    local controlEvent = ControlEvent:init()
    controlEvent:eventRegister(controIdAndEvents)
    --eventRegister(controIdAndEvents)s
end

-- 控件对象返回给公用类
function callControlList(pageDict)
    local page = pageDict["page"]
    page:getControlList(controlListFromOC)
end

--chart单击事件 
function BasicChart86815_singleTap(dict)
    print("--------------------------------------------------------")
    local singleTapControlId = "BasicChart86815"
    local popoverControlId = "BasicChart375232"
    animation:popoverViewControlId_andSingleTapControlID_andXYDict(popoverControlId, singleTapControlId, dict)
end
function BasicChart383147_singleTap(dict)
    print("--------------------------------------------------------")
    local singleTapControlId = "BasicChart383147"
    local chartControlId = "BasicChart660499"
    animation:chartLDSingleTap1_chartLDSingleTap2(singleTapControlId, chartControlId )
end
function BasicChart660499_singleTap(dict)
    print("--------------------------------------------------------")
    local singleTapControlId = "BasicChart660499"
    local chartControlId = "BasicChart383147"
    animation:chartLDSingleTap1_chartLDSingleTap2(singleTapControlId, chartControlId )
end

--图表捏合放大 DataGrid224761_pinchToEnlarge
function DataGrid224761_pinchToEnlarge()
    local controlId = "DataGrid224761"
    
    animation:controlEnlargeToFullScreen(controlId)
end

function DataGrid224761_pinchToShrink()
    local controlId = "DataGrid224761"
    --local animation = Animations:init()
    animation:controlShrinkToPreFrame(controlId)
 end 
 
 --图表捏合放大 DataGrid904228_pinchToEnlarge
function DataGrid904228_pinchToEnlarge()
    local controlId = "DataGrid904228"
    
    animation:controlEnlargeToFullScreen(controlId)
end

function DataGrid904228_pinchToShrink()
    local controlId = "DataGrid904228"
    --local animation = Animations:init()
    animation:controlShrinkToPreFrame(controlId)
 end 

--chart捏合放大
function BasicChart223325_pinchToEnlarge()
    local controlId = "BasicChart223325"
    
    animation:controlEnlargeToFullScreen(controlId)
end

function BasicChart223325_pinchToShrink()
    local controlId = "BasicChart223325"
    --local animation = Animations:init()
    animation:controlShrinkToPreFrame(controlId)
 end


-- label单击事件
function Label264651_singleTap()
    print("############")
    local controlId1 = "BasicChart383147"
    local controlId2 = "Label264651"
    animation:controlTabelFly1_controlTabelFly2(controlId1, controlId2)
    
end
function Label722286_singleTap()
    print("############")
    local controlId1 = "BasicChart428299"
    local controlId2 = "Label722286"
    animation:controlTabelFly1_controlTabelFly2(controlId1, controlId2)
    
end
function Label263379_singleTap()
    print("############")
    local controlId1 = "BasicChart405406"
    local controlId2 = "Label263379"
    animation:controlTabelFly1_controlTabelFly2(controlId1, controlId2)
    
end
function Label520546_singleTap()
    print("############")
    local controlId1 = "BasicChart325779"
    local controlId2 = "Label520546"
    animation:controlTabelFly1_controlTabelFly2(controlId1, controlId2)
    
end
-- panel单击事件
function Panel820587_singleTap()
    print("############")
    --local controlId = "BasicChart383147"
    animation:controlTabelFly(controlId)
end

