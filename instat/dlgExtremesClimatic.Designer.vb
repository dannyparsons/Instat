﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExtremesClimatic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayOfYear = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.grpMaxMin = New System.Windows.Forms.GroupBox()
        Me.grpPeaks = New System.Windows.Forms.GroupBox()
        Me.lblThresh = New System.Windows.Forms.Label()
        Me.rdoMinMax = New System.Windows.Forms.RadioButton()
        Me.rdoPeaks = New System.Windows.Forms.RadioButton()
        Me.lblData = New System.Windows.Forms.Label()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrChkDayNumber = New instat.ucrCheck()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrChkThreshold = New instat.ucrCheck()
        Me.ucrInputThreshhold = New instat.ucrInputTextBox()
        Me.ucrChkMaxima = New instat.ucrCheck()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStations = New instat.ucrReceiverSingle()
        Me.ucrSelectorClimaticExtremes = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlMinMaxPeaks = New instat.UcrPanel()
        Me.ucrInputSave = New instat.ucrInputTextBox()
        Me.grpMaxMin.SuspendLayout()
        Me.grpPeaks.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.Location = New System.Drawing.Point(241, 46)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(48, 13)
        Me.lblStations.TabIndex = 11
        Me.lblStations.Text = "Stations:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(240, 91)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(240, 139)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 13
        Me.lblYear.Text = "Year:"
        '
        'lblDayOfYear
        '
        Me.lblDayOfYear.AutoSize = True
        Me.lblDayOfYear.Location = New System.Drawing.Point(244, 188)
        Me.lblDayOfYear.Name = "lblDayOfYear"
        Me.lblDayOfYear.Size = New System.Drawing.Size(68, 13)
        Me.lblDayOfYear.TabIndex = 14
        Me.lblDayOfYear.Text = "Day Of Year:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(37, 246)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 17
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(129, 247)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 18
        Me.lblTo.Text = "To:"
        '
        'grpMaxMin
        '
        Me.grpMaxMin.Controls.Add(Me.ucrChkMaxima)
        Me.grpMaxMin.Location = New System.Drawing.Point(10, 278)
        Me.grpMaxMin.Name = "grpMaxMin"
        Me.grpMaxMin.Size = New System.Drawing.Size(165, 100)
        Me.grpMaxMin.TabIndex = 19
        Me.grpMaxMin.TabStop = False
        Me.grpMaxMin.Text = "Max/Min"
        '
        'grpPeaks
        '
        Me.grpPeaks.Controls.Add(Me.ucrChkThreshold)
        Me.grpPeaks.Controls.Add(Me.lblThresh)
        Me.grpPeaks.Controls.Add(Me.ucrInputThreshhold)
        Me.grpPeaks.Location = New System.Drawing.Point(219, 280)
        Me.grpPeaks.Name = "grpPeaks"
        Me.grpPeaks.Size = New System.Drawing.Size(165, 100)
        Me.grpPeaks.TabIndex = 20
        Me.grpPeaks.TabStop = False
        Me.grpPeaks.Text = "Peaks"
        '
        'lblThresh
        '
        Me.lblThresh.AutoSize = True
        Me.lblThresh.Location = New System.Drawing.Point(6, 16)
        Me.lblThresh.Name = "lblThresh"
        Me.lblThresh.Size = New System.Drawing.Size(30, 13)
        Me.lblThresh.TabIndex = 18
        Me.lblThresh.Text = "From"
        '
        'rdoMinMax
        '
        Me.rdoMinMax.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMinMax.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMinMax.FlatAppearance.BorderSize = 2
        Me.rdoMinMax.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMinMax.Location = New System.Drawing.Point(132, 12)
        Me.rdoMinMax.Name = "rdoMinMax"
        Me.rdoMinMax.Size = New System.Drawing.Size(72, 27)
        Me.rdoMinMax.TabIndex = 23
        Me.rdoMinMax.TabStop = True
        Me.rdoMinMax.Text = "Min/Max"
        Me.rdoMinMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMinMax.UseVisualStyleBackColor = True
        '
        'rdoPeaks
        '
        Me.rdoPeaks.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPeaks.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPeaks.FlatAppearance.BorderSize = 2
        Me.rdoPeaks.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPeaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPeaks.Location = New System.Drawing.Point(203, 12)
        Me.rdoPeaks.Name = "rdoPeaks"
        Me.rdoPeaks.Size = New System.Drawing.Size(69, 27)
        Me.rdoPeaks.TabIndex = 24
        Me.rdoPeaks.TabStop = True
        Me.rdoPeaks.Text = "Peaks"
        Me.rdoPeaks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPeaks.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(243, 236)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(33, 13)
        Me.lblData.TabIndex = 29
        Me.lblData.Text = "Data:"
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Location = New System.Drawing.Point(244, 252)
        Me.ucrReceiverData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverData.TabIndex = 28
        Me.ucrReceiverData.ucrSelector = Nothing
        '
        'ucrChkDayNumber
        '
        Me.ucrChkDayNumber.Checked = False
        Me.ucrChkDayNumber.Location = New System.Drawing.Point(10, 381)
        Me.ucrChkDayNumber.Name = "ucrChkDayNumber"
        Me.ucrChkDayNumber.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDayNumber.TabIndex = 27
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(154, 244)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 21
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkThreshold
        '
        Me.ucrChkThreshold.Checked = False
        Me.ucrChkThreshold.Location = New System.Drawing.Point(8, 65)
        Me.ucrChkThreshold.Name = "ucrChkThreshold"
        Me.ucrChkThreshold.Size = New System.Drawing.Size(143, 20)
        Me.ucrChkThreshold.TabIndex = 19
        '
        'ucrInputThreshhold
        '
        Me.ucrInputThreshhold.AddQuotesIfUnrecognised = True
        Me.ucrInputThreshhold.IsMultiline = False
        Me.ucrInputThreshhold.IsReadOnly = False
        Me.ucrInputThreshhold.Location = New System.Drawing.Point(8, 31)
        Me.ucrInputThreshhold.Name = "ucrInputThreshhold"
        Me.ucrInputThreshhold.Size = New System.Drawing.Size(85, 21)
        Me.ucrInputThreshhold.TabIndex = 0
        '
        'ucrChkMaxima
        '
        Me.ucrChkMaxima.Checked = False
        Me.ucrChkMaxima.Location = New System.Drawing.Point(7, 25)
        Me.ucrChkMaxima.Name = "ucrChkMaxima"
        Me.ucrChkMaxima.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMaxima.TabIndex = 0
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(72, 243)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 15
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(245, 204)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDOY.TabIndex = 10
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(245, 155)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.TabIndex = 9
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(243, 107)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.TabIndex = 8
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStations
        '
        Me.ucrReceiverStations.frmParent = Me
        Me.ucrReceiverStations.Location = New System.Drawing.Point(243, 60)
        Me.ucrReceiverStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStations.Name = "ucrReceiverStations"
        Me.ucrReceiverStations.Selector = Nothing
        Me.ucrReceiverStations.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStations.TabIndex = 7
        Me.ucrReceiverStations.ucrSelector = Nothing
        '
        'ucrSelectorClimaticExtremes
        '
        Me.ucrSelectorClimaticExtremes.bShowHiddenColumns = False
        Me.ucrSelectorClimaticExtremes.bUseCurrentFilter = True
        Me.ucrSelectorClimaticExtremes.Location = New System.Drawing.Point(10, 52)
        Me.ucrSelectorClimaticExtremes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticExtremes.Name = "ucrSelectorClimaticExtremes"
        Me.ucrSelectorClimaticExtremes.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorClimaticExtremes.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 432)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(398, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrPnlMinMaxPeaks
        '
        Me.ucrPnlMinMaxPeaks.Location = New System.Drawing.Point(131, 6)
        Me.ucrPnlMinMaxPeaks.Name = "ucrPnlMinMaxPeaks"
        Me.ucrPnlMinMaxPeaks.Size = New System.Drawing.Size(141, 37)
        Me.ucrPnlMinMaxPeaks.TabIndex = 22
        '
        'ucrInputSave
        '
        Me.ucrInputSave.AddQuotesIfUnrecognised = True
        Me.ucrInputSave.IsMultiline = False
        Me.ucrInputSave.IsReadOnly = False
        Me.ucrInputSave.Location = New System.Drawing.Point(12, 409)
        Me.ucrInputSave.Name = "ucrInputSave"
        Me.ucrInputSave.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSave.TabIndex = 30
        '
        'dlgExtremesClimatic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 493)
        Me.Controls.Add(Me.ucrInputSave)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.ucrChkDayNumber)
        Me.Controls.Add(Me.rdoPeaks)
        Me.Controls.Add(Me.rdoMinMax)
        Me.Controls.Add(Me.ucrNudTo)
        Me.Controls.Add(Me.grpPeaks)
        Me.Controls.Add(Me.grpMaxMin)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.ucrNudFrom)
        Me.Controls.Add(Me.lblDayOfYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStations)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStations)
        Me.Controls.Add(Me.ucrSelectorClimaticExtremes)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlMinMaxPeaks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExtremesClimatic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extremes Climatic"
        Me.grpMaxMin.ResumeLayout(False)
        Me.grpPeaks.ResumeLayout(False)
        Me.grpPeaks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorClimaticExtremes As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStations As ucrReceiverSingle
    Friend WithEvents grpPeaks As GroupBox
    Friend WithEvents lblThresh As Label
    Friend WithEvents ucrInputThreshhold As ucrInputTextBox
    Friend WithEvents grpMaxMin As GroupBox
    Friend WithEvents ucrChkMaxima As ucrCheck
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents lblDayOfYear As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStations As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrChkThreshold As ucrCheck
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrPnlMinMaxPeaks As UcrPanel
    Friend WithEvents rdoPeaks As RadioButton
    Friend WithEvents rdoMinMax As RadioButton
    Friend WithEvents ucrChkDayNumber As ucrCheck
    Friend WithEvents lblData As Label
    Friend WithEvents ucrReceiverData As ucrReceiverSingle
    Friend WithEvents ucrInputSave As ucrInputTextBox
End Class
