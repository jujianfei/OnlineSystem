var dialogInstace , onMoveStartId , mousePos = {x:0,y:0};	//	���ڼ�¼��ǰ����ק�Ķ���
	function g(id){return document.getElementById(id);}
	function autoCenter( el ){
		var bodyW = document.documentElement.clientWidth;
		var bodyH = document.documentElement.clientHeight;
		var elW = el.offsetWidth;
		var elH = el.offsetHeight;
		el.style.left = (bodyW-elW)/2 + 'px';
		el.style.top = (bodyH-elH)/2 + 'px';
	}
	function fillToBody( el ){
		el.style.width  = document.documentElement.clientWidth  +'px';
		el.style.height = document.documentElement.clientHeight + 'px';
	}
	function Dialog( dragId , moveId ){
		var instace = {} ;
		instace.dragElement  = g(dragId);	//	����ִ�� ��ק���� ��Ԫ��
		instace.moveElement  = g(moveId);	//	��ק����ʱ���ƶ���Ԫ��
		instace.mouseOffsetLeft = 0;			//	��ק����ʱ���ƶ�Ԫ�ص���ʼ X ��
		instace.mouseOffsetTop = 0;			//	��ק����ʱ���ƶ�Ԫ�ص���ʼ Y ��
		instace.dragElement.addEventListener('mousedown',function(e){
			var e = e || window.event;
			dialogInstace = instace;
			instace.mouseOffsetLeft = e.pageX - instace.moveElement.offsetLeft ;
			instace.mouseOffsetTop  = e.pageY - instace.moveElement.offsetTop ;	
			onMoveStartId = setInterval(onMoveStart,10);
			return false;
		})
		return instace;
	}
	//	��ҳ�������� ��굯���¼�
	document.onmouseup = function(e){
		dialogInstace = false;
		clearInterval(onMoveStartId);
	}
	document.onmousemove = function( e ){
		var e = window.event || e;
		mousePos.x = e.clientX;
		mousePos.y = e.clientY;
		e.stopPropagation && e.stopPropagation();
		e.cancelBubble = true;
		e = this.originalEvent;
        e && ( e.preventDefault ? e.preventDefault() : e.returnValue = false );
        document.body.style.MozUserSelect = 'none';
	}	
	function onMoveStart(){
		var instace = dialogInstace;
	    if (instace) {
	    	var maxX = document.documentElement.clientWidth -  instace.moveElement.offsetWidth;
	    	var maxY = document.documentElement.clientHeight - instace.moveElement.offsetHeight ;
			instace.moveElement.style.left = Math.min( Math.max( ( mousePos.x - instace.mouseOffsetLeft) , 0 ) , maxX) + "px";
			instace.moveElement.style.top  = Math.min( Math.max( ( mousePos.y - instace.mouseOffsetTop ) , 0 ) , maxY) + "px";
	    }

	}
	//	���µ����Ի����λ�ú����֣�����չ��
	function showDialog(){
		g('dialogMove').style.display = 'block';
		g('mask').style.display = 'block';
		autoCenter( g('dialogMove') );
		fillToBody( g('mask') );
	}
	//	�رնԻ���
	function hideDialog(){
		g('dialogMove').style.display = 'none';
		g('mask').style.display = 'none';
	}
	//	������������ڴ�С�仯
	//window.onresize = showDialog;
	Dialog('dialogDrag','dialogMove');
	showDialog();