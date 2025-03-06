# 3D Top Down Shooter Prototype
</br>
Unity Version:2023.2.20f1</br>
</br>
Projemi açmak için yapılması gerekenler;</br>
1)Proje Dosyasını İndirin: Proje dosyasını bilgisayarınıza indirin veya yerel bir klasöre kopyalayın.</br>
2)Unity Hub Üzerinden Projeyi Açın:</br>
Unity Hub'ı açın.</br>
Sol menüde yer alan Projects sekmesine tıklayın.</br>
Sağ üst köşede bulunan Open butonuna tıklayın.</br>
Proje dosyasının yer aldığı klasörü seçin ve Select Folder butonuna tıklayın.</br>
Unity, projeyi tanıyacak ve proje listesinde gösterecektir.</br>
Proje listesinde, açmak istediğiniz projeye çift tıklayın veya Open butonuna basın.</br>
3)Unity Sürümünü Kontrol Edin: Proje için önerilen Unity sürümünü kullanmanız tavsiye edilir. Eğer proje farklı bir Unity sürümünde oluşturulmuşsa, Unity Hub size bir uyarı verecektir. Uygun sürüm yüklü değilse, Unity Hub üzerinden uygun sürümü indirip yükleyebilirsiniz.</br>
4)Proje Açıldıktan Sonra: Assets klasörü altında yer alan Scenes klasöründen Scene adındaki oyun sahnesini bulup çift tıklayarak açın.</br>
</br>
Projem İçin Kullandığım Assetler;</br>
-Karakter ve animasyonlar için Unity Asset Store'dan almış olduğum Low Poly Soldiers Demo (from Polygon Blacksmith [V1.0])</br>
</br>
Projemde zorlandığım kısımlar;</br>
-Animasyon geçişleri</br>
-Karakterin öteleme hızı ve dönme hızı için threshold ayarlama</br>
-Kameranın karakterimiz rotate ettikçe onunla birlikte dönmesi</br>
</br>
Çözümler;
-Animasyon geçişleri için has exit time kapatarak, transition duration süresini kısalttım.</br>
-Threshold için birden fazla test denemesi yaptım.</br>
-Quaternion LERP fonksiyonunu kullanmayı öğrendim. </br>
