from gtts import gTTS
import hashlib
import sys

# Lấy đoạn văn bản từ tham số dòng lệnh, trong trường hợp này là văn bản tiếng Việt
txt = sys.argv[1]

# Tạo chuỗi tên file = md5(dữ liệu đầu vào) => chuỗi 32 kí tự
fn = hashlib.md5(txt.encode("utf-8")).hexdigest() + ".mp3"

# Gọi thư viện để chuyển đổi văn bản trong txt sang định dạng âm thanh MP3 tiếng Việt
tts = gTTS(text=txt, lang="vi", slow=False)

# Lưu tập tin âm thanh MP3 vào đĩa, tập tin này chứa âm thanh để truyền;
tts.save(fn)

# In ra tên tập tin vừa lưu trên console
print(fn)