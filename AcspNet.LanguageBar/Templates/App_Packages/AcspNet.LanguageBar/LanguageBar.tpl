<script type="text/javascript">
	function ChangeLanguage()
	{
		$('#LanguageBar').submit();
	}
</script>

<form id="LanguageBar" action="{~}/changeLanguage" method="post">
	<select name="Language" onchange="ChangeLanguage();">
		{LanguagesList}
	</select>
</form>
