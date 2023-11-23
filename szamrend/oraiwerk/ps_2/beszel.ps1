# Add-Type -AssemblyName System.Speech
# $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer
# $speak.Speak("hogy a macska rúgja meg")

# todo: get the installed voices
$voices = [System.Speech.Synthesis.SpeechSynthesizer]::InstalledVoices

# todo: convert the voices to a CSV file
$voices | Select-Object -Property VoiceInfo | Export-Csv -Path "C:\Users\palyi\Desktop\bullshitbundle\susuwerk\szamrend\oraiwerk\voices.csv" -NoTypeInformation

# todo: convert csv to html
$voices | Select-Object -Property VoiceInfo | Export-Csv -Path "C:\Users\palyi\Desktop\bullshitbundle\susuwerk\szamrend\oraiwerk\voices.csv" -NoTypeInformation | ConvertTo-Html


