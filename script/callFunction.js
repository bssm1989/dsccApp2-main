console.log("Hello World!")
function autoTab(obj, value) {
	//debugger;
	/* กำหนดรูปแบบข้อความโดยให้ _ แทนค่าอะไรก็ได้ แล้วตามด้วยเครื่องหมาย
	หรือสัญลักษณ์ที่ใช้แบ่ง เช่นกำหนดเป็น  รูปแบบเลขที่บัตรประชาชน
	4-2215-54125-6-12 ก็สามารถกำหนดเป็น  _-____-_____-_-__
	รูปแบบเบอร์โทรศัพท์ 08-4521-6521 กำหนดเป็น __-____-____
	หรือกำหนดเวลาเช่น 12:45:30 กำหนดเป็น __:__:__
	ตัวอย่างข้างล่างเป็นการกำหนดรูปแบบเลขบัตรประชาชน
	*/
	if (event.keyCode < 48 || event.keyCode > 57) { event.returnValue = false }

	switch (value) {
		case 1:
			var pattern = new String("_-____-_____-__-_"); // กำหนดรูปแบบในนี้
			break;
		case 2:
			var pattern = new String("__-____-____"); // กำหนดรูปแบบในนี้
			break;
		case 3:
			var pattern = new String("____-______-_"); // กำหนดรูปแบบในนี้
			break;
	}

	var pattern_ex = new String("-"); // กำหนดสัญลักษณ์หรือเครื่องหมายที่ใช้แบ่งในนี้
	var returnText = new String("");
	var obj_l = obj.value.length;
	var obj_l2 = obj_l - 1;
	for (i = 0; i < pattern.length; i++) {
		if (obj_l2 == i && pattern.charAt(i + 1) == pattern_ex) {
			returnText += obj.value + pattern_ex;
			obj.value = returnText;
		}
	}
	if (obj_l >= pattern.length) {
		obj.value = obj.value.substr(0, pattern.length);
	}
}
function HC_out(obj, callback) {
	if (obj.HC.value != '') {
		if (obj.HC.value.length != 13) {
			alert("กรุณากรอก รหัสบ้าน ให้ถูกต้อง")
			obj.HC.focus();
		} else {
			var script = document.createElement('script');
			script.src = 'search_hc.php?hc=' + obj.HC.value;
			document.head.appendChild(script);
		}

	}
}
function SaveClick(obj) {

	if (parseInt(obj.HHM.value) < parseInt(obj.PPP.value)) { obj.HHM.value = obj.PPP.value }

	if (obj.HC.value.length != 13) {
		alert('กรุณากรอกรหัสบ้านให้ครบ 11 ตัว')
		obj.HC.focus();
	} else if (obj.PP.value == '') {
		alert('กรุณากรอก จำนวนคนที่อยู่จริง')
		obj.PP.focus();
	} else {
		obj.next.value = 1
		obj.submit()
	}
}

function NextClick(obj) {
	if (confirm('ท่านไม่ต้องการบันทึกข้อมูลใช่หรือไม่')) {
		obj.next.value = 0
		obj.submit();
	}
}