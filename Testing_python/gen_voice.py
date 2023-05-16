#code by Đỗ Duy Cốp
#cho lớp 56KMT, thực hành buổi số 2 ngày 10.5.2023

import sys								#thư viện để đọc tham số dòng lệnh truyền vào, có sẵn
from hashlib import md5					#thư viện để gọi md5, cài đặt: pip install hashlib
import os								#thư viện để kiểm tra file đã có chưa. có sẵn
from gtts import gTTS					#thư viện để chuyển text -> mp3, cài đặt gtts: pip install gTTS
from playsound import playsound			#thư viện để play file âm thanh mp3 ngay, ko cần window media trên c#, cài đặt: pip install playsound

language = sys.argv[1]									#lấy ngôn ngữ 
text = sys.argv[2]										#lấy dữ liệu truyền vào từ tham số dòng lệnh, đây là văn bản cần chuyển sang âm thanh

byte_array = (language+'@'+text).encode("utf-8")		#chuyển đầu vào thành mảng các byte, vì md5 yêu cầu thế
fn = md5(byte_array).hexdigest()+".mp3"					#tạo ra chuỗi tên file = md5 (đầu vào) => chuỗi 32 kí tự, ghép thêm đuôi mp3

if not os.path.exists(fn):								#NẾU CHƯA TỒN TẠI FILE THÌ MỚI CẦN GTTS SINH RA MP3
	try:												#bẫy lỗi
		tts = gTTS(text, lang=language, slow=False)		#gọi thư viện để chuyển văn bản trong txt -> sang dạng âm thanh
		tts.save(fn)									#lưu ra file trên ổ đĩa, file này chứa âm thanh cần chuyển
		print(fn)										#in ra console chuỗi tên file vừa lưu
		playsound(fn, True)								#play ra loa
	except Exception as e:								#xử lý các lỗi phát sinh
		print (e)										#print ra báo lỗi còn lại
else:													#đây là file đã tồn tại rồi
	print(fn)											#in ra console chuỗi tên file đã lưu từ lần trước
	playsound(fn, True)									#play ra loa